using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInviteSite.Models;


namespace PartyInviteSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index() //Мейн страница, которая показывает время и содержит в себе ссылку на страницу регистрации
        {
            int hour = DateTime.Now.Hour;
            ViewBag.DateReturn = hour > 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
       [HttpGet]
        public IActionResult RsvpForm() //GET метод RsvpForm.cshtml (view), которая просто выводит представление
        {
          return View();
        }
        [HttpPost] 
        public IActionResult RsvpForm(GuesResponse guesResponse)//?перегруженный? POST метод, который принимает коллекцию типа GuesResponse и возвращает View Thanks.cshtml 
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guesResponse);
                return View("Thanks", guesResponse); // обязательно нужно передать guesResponse, иначе будет ошибка, хз еще не понял почему
            }
            else
                return View();
        }
        public IActionResult Privacy()
        {
            
            return View();
        }

        public ViewResult ListResponses()
        {
            //Linq запрос, который ?дрбавляет в коллекцию Респонсес тех, у кого вилл аттенд == тру, затем выводит в вью и передает ей значения?
            return View(Repository.Responses.Where(r => r.WillAttend == true)); ;
        }
       
    }
}
