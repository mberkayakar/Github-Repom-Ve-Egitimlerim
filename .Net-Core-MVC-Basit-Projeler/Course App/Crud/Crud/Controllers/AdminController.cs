using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Models;
namespace Crud.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Egitmenkaydet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Egitmenkaydet(Egitmen kaydedilecekegitmen)
        {
            if (ModelState.IsValid==true)   // gelen model içerisindeki kurallara bakar 
            {
                Repository.addegitimci(kaydedilecekegitmen);
                return View("EğitmenKaydıBaşarılı", kaydedilecekegitmen);
            }
            else
            {
                return View(kaydedilecekegitmen);
            }



           
        }


        public IActionResult index()
        {
            return View();
        }

        public IActionResult EgitimcilerBolumu()
        {
            var egitimcilerlistesi = Repository.Egitimci.ToList();
            return View(egitimcilerlistesi);

        }
    }
}
