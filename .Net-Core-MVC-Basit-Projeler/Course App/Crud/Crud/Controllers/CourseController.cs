using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Models;


namespace Crud.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TumEgitimler()
        {
            var kurs = new Kurslar();
            
            kurs.id = 1;
            kurs.fotograf = "url";
            kurs.kursadi = ".Net Core MVC Kampı";
            kurs.published = true;
            kurs.Eğitmen = "Berkay AKAR";
            kurs.egitimucreti = 2500;

            var kurs2 = new Kurslar();
            kurs2.id = 2;
            kurs2.fotograf = "url";
            kurs2.kursadi = "Yazılımcı Geliştirme Kampı";
            kurs2.published = true;
            kurs2.Eğitmen = "Berkay AKAR";
            kurs2.egitimucreti = 3000;


            List<Kurslar> kurslar = new List<Kurslar>()
            {
                kurs,kurs2
            };
            return View(kurslar);
        }
    }
}
