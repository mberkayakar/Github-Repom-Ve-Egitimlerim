using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreMVCProject.Models;
using FirstCoreMVCProject.Entities;

namespace FirstCoreMVCProject
{
    public class AnaSayfaController : Controller
    {
        // Görüldüğü üzere bir fonksiyon döndürüp string bir ifade ile karşılaşılabilir. Mandık Djangodaki ile aynı
        public string Normalbirfonksiyondön()
        {
            return "hello world";
        }

        public string Degerdondur(string gelen)
        {


        string deger = "hoşgeldin : " + gelen;
            return deger;
        }



        // Viewler oluşturulurken contollerdeki fonksiyonun ismi verilmelidir aksi taktirde çalışmaz
        public IActionResult index()
        {
            return View();
        }

   
        public IActionResult index3()
        {

        List<Costumers> musteri = new List<Costumers> {
            new Costumers  {isim="berkay", soyisim="akar", yas=22},
            new Costumers { isim = "berkay2", soyisim = "akar", yas = 22 },
            new Costumers { isim = "berkay3", soyisim = "akar", yas = 22 },
            };


        return View(musteri);
       
    
    
        }
    }
}
