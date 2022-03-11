using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using shopapp.business.Abstract;
using shopapp.business.Concrete;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;
using shopapp.webui.EmailServices;
using shopapp.webui.Identity;

namespace shopapp.webui
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            this._configuration =configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
 

            // services.AddDbContext<ApplicationContext>(options=> options.UseMySQL("Server=localhost;Database=ShopDb;Uid=auth_windows;Persist Security Info=True;User=root;Password=root"));
            services.AddDbContext<ApplicationContext>(options=> options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));
            services.AddDbContext<ShopContext>(options=> options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));

            services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            
            services.Configure<IdentityOptions>(options=>{
                //pasword
                options.Password.RequireDigit =true;
                options.Password.RequireLowercase=true;
                options.Password.RequireUppercase=true;
                options.Password.RequiredLength =6;
                options.Password.RequireNonAlphanumeric=false;

                // Lockout
                options.Lockout.MaxFailedAccessAttempts =5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers=true;

                // User
                // options.User.AllowedUserNameCharacters="";
                options.User.RequireUniqueEmail=true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber=false;

            });
  
            services.ConfigureApplicationCookie(options=>{
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ShopApp.Security.Cookie",
                    // SameSite = SameSiteMode.Strict
                };
            });

            // mvc
            // razor pages

            services.AddScoped<IUnitOfWork,UnitOfWork>();
           
            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICardService,CardManager>();
            services.AddScoped<IOrderService,OrderManager>();

            services.AddScoped<IEmailSender,SmtpEmailSender>(i=>
                new SmtpEmailSender(
                    _configuration["EmailSender:Host"],
                    _configuration.GetValue<int>("EmailSender:Port"),
                    _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    _configuration["EmailSender:UserName"],
                    _configuration["EmailSender:Password"]
                    ));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager,ICardService cardService)
        {
            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions{
                FileProvider = new PhysicalFileProvider(
                        Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                        RequestPath="/modules"            
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
             
            }
            
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            // localhost:5000
            // localhost:5000/products
            // localhost:5000/products/5
            // localhost:5000/products/details/5
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"checkout",
                    pattern: "checkout",
                    defaults: new {controller="Card",action="Checkout"}
                );
                endpoints.MapControllerRoute(
                    name:"cards",
                    pattern: "card",
                    defaults: new {controller="Card",action="Index"}
                );
                endpoints.MapControllerRoute(
                    name:"adminuseredit",
                    pattern: "admin/user/{id?}",
                    defaults: new {controller="Admin",action="UserEdit"}
                );
                endpoints.MapControllerRoute(
                    name:"adminusers",
                    pattern: "admin/user/list",
                    defaults: new {controller="Admin",action="UserList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminroles",
                    pattern: "admin/role/{id?}",
                    defaults: new {controller="Admin",action="RoleEdit"}
                );
                endpoints.MapControllerRoute(
                    name:"adminroles",
                    pattern: "admin/role/list",
                    defaults: new {controller="Admin",action="RoleList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminrolecreate",
                    pattern: "admin/role/create",
                    defaults: new {controller="Admin",action="RoleCreate"}
                );
               // admin products
                endpoints.MapControllerRoute(
                    name:"adminproducts",
                    pattern: "admin/products",
                    defaults: new {controller="Admin",action="ProductList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminproducts",
                    pattern: "admin/products/create",
                    defaults: new {controller="Admin",action="ProductCreate"}
                );
                endpoints.MapControllerRoute(
                    name:"adminproductedit",
                    pattern: "admin/products/{id?}",
                    defaults: new {controller="Admin",action="ProductEdit"}
                );
                // admin categories
                 endpoints.MapControllerRoute(
                    name:"admincategories",
                    pattern: "admin/categories",
                    defaults: new {controller="Admin",action="CategoryList"}
                );
                endpoints.MapControllerRoute(
                    name:"admincategorycreate",
                    pattern: "admin/categories/create",
                    defaults: new {controller="Admin",action="CategoryCreate"}
                );
                endpoints.MapControllerRoute(
                    name:"admincategoryedit",
                    pattern: "admin/categories/{id?}",
                    defaults: new {controller="Admin",action="CategoryEdit"}
                );
                
                endpoints.MapControllerRoute(
                    name:"search",
                    pattern: "search",
                    defaults: new {controller="Shop",action="search"}
                );
                endpoints.MapControllerRoute(
                    name:"productdetails",
                    pattern: "{url}",
                    defaults: new {controller="Shop",action="details"}
                );
                endpoints.MapControllerRoute(
                    name:"products",
                    pattern: "products/{category?}",
                    defaults: new {controller="Shop",action="list"}
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
            
            SeedIdentity.Seed(userManager,roleManager,configuration,cardService).Wait();
        }
    }
}
