using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{   

    public class HomeController:Controller
    {  
        private IProductService _productService;
        
        public HomeController(IProductService productService)
        {
            this._productService=productService;
        }
        public IActionResult Index()
        {
            
             var productViewModel= new ProductViewModel()
             {  
                 
                 Products= _productService.GetHomePageProducts()
             };

            return View(productViewModel);
        }
        public async Task<IActionResult> GetsProductsFromRestApi()
        {
            var products =new List<Product>();
            using(var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:4200/api/products"))
                {
                    string apiresponse = await response.Content.ReadAsStringAsync();

                    products = JsonConvert.DeserializeObject<List<Product>>(apiresponse);
                }
            }
            return View(products);   
        }
        public IActionResult About(){
            return View();
        }
        public IActionResult Contact(){
            return View();
        }
    }
}