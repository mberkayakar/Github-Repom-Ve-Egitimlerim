using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    // Classlar Özellik Ve Operasyon tutar 

    // ÖZellik Değişkenleri : (Property)

    // Operasyon ise Fonskiyonlar manasına gelir. 

    //( Manager , Servis , Data , Acces , Controller , Dal)
    class SepetManager // Bunlar bir operasyon tutuyor demek   
    {
        // Ürün Ekleme İşini yapacagız
        public void Ekle()
        {
            Console.WriteLine("Tebrikler Ürün Eklendi");
        }


        public void Ekle(Product urun, int adet )  //(tipi (ojce string veya sınıf gibi )    -    Degişken)  // Overloading: bir fonksiyonun farklı parametreli versiyonu (isim aynı olması lazım)
        {
            Console.WriteLine("Tebrikler sepete "+ urun.Ad+ " isimli ürün eklendi");
            Console.WriteLine("stok adeti " + Product.kontejyan+ " iken");
            Product.kontejyan = Product.kontejyan  + adet;
            Console.WriteLine("stok adeti " + Product.kontejyan + " olarak güncellendi");
        }
    }
}
