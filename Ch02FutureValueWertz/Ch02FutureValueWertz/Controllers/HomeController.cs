using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ch02FutureValueWertz.Models;

namespace Ch02FutureValueWertz.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fv = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Fv = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.Fv = 0;
            }
            return View(model);
        }
    }
}