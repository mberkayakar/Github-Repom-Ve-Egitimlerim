using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            İnsanlar insan1 = new İnsanlar();
            insan1.İsim = "berkay";
            insan1.Soyisim = "Akar";


            İnsanlar insan2 = new İnsanlar();
            insan2.İsim = "İlhan";
            insan2.Soyisim = "Akar";

            İnsanlar insan3 = new İnsanlar();
            insan3.İsim = "Ayten";
            insan3.Soyisim = "Akar";

            //Console.WriteLine(insan2); // Statik bir şekilde nesneleme
            // Böyel yaparsan Obcejt yazar isan1.isim yazman lazım


            // dinamik bir şekilde listelemek isteseydik hepsini bir Dizi içerisinde listeletebilirdik
           
            İnsanlar[] İnsansırala = new İnsanlar[] { insan1,insan2,insan3};

            foreach (var insan in İnsansırala)
            {
                Console.WriteLine(" İsim : "+insan.İsim+" Soyisim :  "+insan.Soyisim);
            }
            Console.WriteLine("  ");
            Console.WriteLine(" ************************************************************** ");
            Console.WriteLine(" ************************ İkinci kısım ************************ ");
            Console.WriteLine(" ************************************************************** ");
            Console.WriteLine("  ");

            // ***************************************************************************** //


            Product product1= new Product();
            product1.Id= 1;
            product1.Ad = "Çamaşır Makinesi";
            product1.Fiyat = 12.500;
            product1.Aciklama = "5 kg lık";


            Product product2 = new Product();
            product2.Id = 2;
            product2.Ad = "Bulaşık makinesi";
            product2.Fiyat = 7.200;
            product2.Aciklama = " Beyaz Eşya Son Model ";

            Product product3 = new Product { Id=1,Ad ="Ütü",Aciklama="Kaliteli Bir Buharlı Ütü",Fiyat=120.50};  // İnline Tanımlama


            Product[] liste = new Product[] { product1, product2, product3 };  
            // sadece product sınıfının nesnelerini koyabilirisn yani insan sınıfından koyamazssın
            // İnsan1 İnsan2 dersen insan nersnesi Producttan ürelimediği için hata verir

            foreach (var item in liste)
            {
                Console.WriteLine(" Ürün : " + item.Id + " " + item.Ad + " "+item.Fiyat+" "+item.Aciklama);
            }
            /* Alttaki ve üsttekide olur yani sıkıntı yok*/
            /* Var her tütü kabul eden bir tiptir ama bizim tipimiz direk ürün oldugu için ordanda şey olur
             *    mesela listenin hespi sitring ise urun yada var yerine strig yapar 
            
             */
            foreach (Product item in liste)
            {
               // Console.WriteLine(" Ürün : " + item.Id + " " + item.Ad + " " + item.Fiyat + " " + item.Aciklama);
            }


            Console.WriteLine("  ");
            Console.WriteLine(" ************************************************************************** ");
            Console.WriteLine(" ************************ Üçüncü kısım (Methodlar) ************************ ");
            Console.WriteLine(" ************************************************************************** ");
            Console.WriteLine("  ");
 


            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle();
            sepetmanager.Ekle(product1,Convert.ToInt32(6));

            Console.Clear();









            Console.WriteLine("  ");
            Console.WriteLine(" ***************************************************************************************** ");
            Console.WriteLine(" ************************ Üçüncü kısım (Değer Ve Referans Tipler) ************************ ");
            Console.WriteLine(" ***************************************************************************************** ");
            Console.WriteLine("  ");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2=65;

            Console.WriteLine("sayi1 = "+sayi1+"    "+ "sayi2 = " + sayi2);  // Vaue typdir bellek te veri saklanır


            int[] sayilar1 = new int[] { 10, 20, 30, 40, 50 };

            int[] sayilar2 = new int[] { 50, 100, 150, 200, 250 };

            sayilar1 = sayilar2;
            sayilar2[0]=1967;  // Referans type dir bellekte bölüm header da yeri tutuluır


            Console.WriteLine("dizi 1 : "+sayilar1[0]+"   "+ "dizi 2 : " + sayilar2[0]);


        }








































































        /* İnline Class Tanımlama */
        class İnsanlar
        {

            // Değişken tanımlamadanda çalışıyor Ve döndürüyor 

            public String İsim { get; set; }
            public String Soyisim { get; set; }

            /*   Method yazmak   (Fonksiyon)   */


        }




    }
}
