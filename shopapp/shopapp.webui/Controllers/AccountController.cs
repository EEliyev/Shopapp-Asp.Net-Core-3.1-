using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.webui.EmailServices;
using shopapp.webui.Extensions;
using shopapp.webui.Identity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController:Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICardService _cardService;
        public AccountController(ICardService cardService, UserManager<User> userManager,SignInManager<User> signInManager,IEmailSender emailSender)
        {
            this._cardService=cardService;
            this._userManager=userManager;
            this._signInManager=signInManager;
            this._emailSender=emailSender;
        }
        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel(){ReturnUrl = ReturnUrl});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user==null)
            {
                ModelState.AddModelError("","Bu kullanici adi ile daha once hesab olusturulmamis");
                return View(model);
            }

            if(!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("","Lutfen hesabinizi onaylayin");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user,model.Password,false,false);
            
            if(result.Succeeded)
            {
                return Redirect(model.ReturnUrl??"~/");
            }
            ModelState.AddModelError("","Girilen kullanici adi veya parola yanlis");

            return View(model);  
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message",new AlertMessage()
                    {
                        Title="Oturum kapatildi",
                        Message="Oturum kapatildi",
                        AlertType="warning"
                    });
            return Redirect("/home/index");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {   

            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(user,model.Password);
            if(result.Succeeded)
            {
                //generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail","Account",new{
                    userId = user.Id,
                    token = code
                });
                
                //email
                await _emailSender.SendEmailAsync(user.Email,"Hesabinizi onaylayiniz",$"Lutfen email hesabinizi onaylamak icin linke <a href='https://localhost:5001{url}'>Tiklayiniz</a>");

                // await _userManager.AddToRoleAsync(user,"customer");

                return Redirect("/account/login");
            }

            ModelState.AddModelError("","Bilinmeyen bir hata oldu lutfen tekrar deneyin");
            return View(model);   
        }
        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {   
            if(userId==null||token==null)
            {   
                TempData.Put("message",new AlertMessage()
                {
                    Title="Gecersiz token.",
                    Message="Gecersiz token.",
                    AlertType="danger"
                });
                
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if(user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user,token);
                if(result.Succeeded)
                {
                    //card objesini olustur
                    _cardService.InitializeCard(user.Id);
                    TempData.Put("message",new AlertMessage()
                    {
                        Title="Hesabiniz onaylandi.",
                        Message="Hesabiniz onaylandi.",
                        AlertType="success"
                    });
                    return View();
                }
                
            }
            TempData.Put("message",new AlertMessage()
                    {
                        Title="Hesabiniz onaylanmadi.",
                        Message="Hesabiniz onaylanmadi.",
                        AlertType="danger"
                    });

                return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if(string.IsNullOrEmpty(Email))
            {
                return View();
            }
            var user = await _userManager.FindByEmailAsync(Email);
            if(user==null)
            {
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            
            var url = Url.Action("ResetPassword","Account",new{
                    userId = user.Id,
                    token = code
                });
                
                //email
                await _emailSender.SendEmailAsync(Email,"Reset Password",$"Parolanizi yenilemek icin linke <a href='https://localhost:5001{url}'>Tiklayiniz</a>");


            return View();
        }
        public IActionResult ResetPassword(string userId,string token)
        {   
            if(userId==null || token==null)
            {
                return RedirectToAction("Home","Index");
            }
            var model = new ResetPasswordModel(){Token=token};
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {   
            if(ModelState.IsValid)
            {
                return View(model);
            }
            var user= await _userManager.FindByEmailAsync(model.Email);
            if(user==null)
            {
                return RedirectToAction("Home","Index");
            }
            var result = await _userManager.ResetPasswordAsync(user,model.Token,model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Login","Account");
            }
            return View(model);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    
    }
}