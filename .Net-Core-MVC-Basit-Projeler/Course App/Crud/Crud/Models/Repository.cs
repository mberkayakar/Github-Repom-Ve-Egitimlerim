using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Repository
    {

       //            <!-- Private şeklinde bir liste tanımlandı -->
        private static List<Egitmen> _egitimci = new List<Egitmen> ();


    
        // get set private olan değişkeni kamuya açtık
        public static List<Egitmen> Egitimci { get { return _egitimci; } }




        //      ekleme gerçekleşti
        public static void addegitimci (Egitmen egit)
        {
            _egitimci.Add(egit);
        }
 
    }
}
