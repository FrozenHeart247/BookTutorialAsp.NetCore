using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyInviteSite.Controllers
{
    public class testController : Controller
    {
        //Этот контроллер чисто по приколу, для теста
        public IActionResult testGetAction()
        {
            return View("~/Views/Home/Privacy.cshtml"); //Просто преверял работает ли вызов из другой папки 
        //Если написать без указания полного пути, то нихуя не выведется, т.к должна быть соответсвующая папка вьювс (по правилам мвс)
        }
    }
}