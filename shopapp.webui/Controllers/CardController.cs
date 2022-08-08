using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Identity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    [Authorize]
    public class CardController:Controller
    {
        private IOrderService _orderService;
        private ICardService _cardService;
        private UserManager<User> _userManager;
        public CardController(ICardService cardService,UserManager<User> userManager,IOrderService orderService)
        {
            this._cardService=cardService;
            this._userManager=userManager;
            this._orderService=orderService;
        }
        public IActionResult Index()
        {
            var card =_cardService.GetCardByUserId(_userManager.GetUserId(User));
            
            var model =new CardModel()
            {
                CardId=card.Id,
                CardItems = card.CardItems.Select(i=> new CardItemModel()
                {
                    CardItemId = i.Id,
                    ProductId=i.ProductId,
                    Name=i.Product.Name,
                    Price=(double)i.Product.Price,
                    ImageUrl=i.Product.ImageUrl,
                    Quantity=i.Quantity
                }).ToList()
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult AddToCard(int productId,int quantity)
        {
            var userId= _userManager.GetUserId(User);
            _cardService.AddToCard(userId,productId,quantity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteFromCard(int productId)
        {
            var userId= _userManager.GetUserId(User);
            _cardService.DeleteFromCard(userId,productId);
            return RedirectToAction("index");
        }
        public IActionResult Checkout()
        {
            var card =_cardService.GetCardByUserId(_userManager.GetUserId(User));
            
            var orderModel= new OrderModel();

            orderModel.CardModel =new CardModel()
            {
                CardId=card.Id,
                CardItems = card.CardItems.Select(i=> new CardItemModel()
                {
                    CardItemId = i.Id,
                    ProductId=i.ProductId,
                    Name=i.Product.Name,
                    Price=(double)i.Product.Price,
                    ImageUrl=i.Product.ImageUrl,
                    Quantity=i.Quantity
                }).ToList()
            };

            return View(orderModel);
        }
        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            if(ModelState.IsValid)
            {
                var userId=_userManager.GetUserId(User);
                var payment= PaymentProcess();
                var card = _cardService.GetCardByUserId(userId);

                model.CardModel =new CardModel()
            {
                CardId=card.Id,
                CardItems = card.CardItems.Select(i=> new CardItemModel()
                {
                    CardItemId = i.Id,
                    ProductId=i.ProductId,
                    Name=i.Product.Name,
                    Price=(double)i.Product.Price,
                    ImageUrl=i.Product.ImageUrl,
                    Quantity=i.Quantity
                }).ToList()
            };

                if(payment)
                {
                    SaveOrder(model,payment,userId);
                    RemoveFromCardOrders(userId);
                    return View("Succes");
                }
            }
            
            return View(model);
        }
        public IActionResult Succes()
        {
            return View();
        }

        private void RemoveFromCardOrders(string userId)
        {
           
            var itemscard = _cardService.GetCardByUserId(userId);
            foreach (var item in itemscard.CardItems)
            {
                _cardService.DeleteFromCard(userId,item.ProductId);
            }
        }
       

        private void SaveOrder(OrderModel model, bool payment, string userId)
        {
            var order = new Order();

            order.OrderNumber = new Random().Next(111111,999999).ToString();
            order.OrderState = EnumOrderState.completed;
            order.PaymentType = EnumPaymentType.CreditCard;
            order.PaymentId = "123456";
            order.ConversationId = "515151";
            order.OrderDate = new DateTime();
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.UserId=userId;
            order.Address = model.Address;
            order.Phone = model.Phone;
            order.Email= model.Email;
            order.City = model.City;
            order.Note = model.Note;
            
            foreach (var item in model.CardModel.CardItems)
            {
                var orderItem = new OrderItem()
                {
                    Price = item.Price,
                    Quantity= item.Quantity,
                    ProductId=item.ProductId
                };
                order.OrderItems = order.OrderItems==null? new List<OrderItem>():order.OrderItems;
                order.OrderItems.Add(orderItem);
            }
            _orderService.Create(order);


        }

        private bool PaymentProcess()
        {
            return true;
        }
    }
}