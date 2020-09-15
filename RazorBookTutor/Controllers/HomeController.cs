using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorBookTutor.Models;

namespace RazorBookTutor.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            // Product myProd = new Product(1,"asd","asdasd",20M,"asd"); // Без конструктора эта шляпа работать не будет!

            Product myProduct = new Product // Если есть какой-то конструктор, то чтобы вот эта хуета работала, нужен ctor по умолчанию, иначе будет требовать аргументы в скобках().
            {
                ProductID = 1,
                Name = "zxc",
                Description = "description",
                Price = 1337M,
                Category = "category"
            };
           
            
            return View(myProduct); // Если не передать во Вьюев экзампляр, то будет null reference exeption, т.к передаются данные из модели в index.cshtml
            //Можно типа инициализировать в самой модели, но экземпляр передать все равно придется 
        }
    }
}