using System;
/* 

                Kodlama İO yazılım geliştirici yetiştirme kampı


*  En yogun kullanılan alan  java harici backend geliştirmede kullanılır

*  .Net Framework yapısı ile gelir. C# ı çalıştırdığımız bir framework yapısır

*  C# ile uygulamalar geliştirmemizi sağlar

*  .net framework sadece windows ta iken core ile cross platform desteği geldi

 *  Core teknolojisi ile farklı işletim sistemleri ve platformlardada çalışabilmeye başladı
    bu sebeple .net framwork yerine .net core ile çalıştırılması uygundur.,


*   pascal case şekilnde kelinmelerin ilk harfilerini büyük alır c# proje isimleri

*   main içerisinde ne varsa o çalışır nesneler için mainden tetiklemeler yapmamız gerekir.

 */


namespace ConsoleApp1
{
    class Program
    {

        public static string gelen_kelimeyi_yazdir(string a)
        {
            return a;
        }
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //  ekran çıktısı vermeyi gösterir.

            //Console.WriteLine(gelen_kelimeyi_yazdir("deneme bir iki üç"));
            //  Console.Clear();  çıktıyı temizler 

            // değişkenler veri tutuculardır. 

           // string degisken = "değişken";
           // Console.Write(degisken);

            /*
            Console.Write(degisken);
            Console.WriteLine(degisken);
            Console.WriteLine(degisken);
            Console.Write(degisken+" yeni satır bak dikkat et");
            Console.WriteLine(degisken+"şimdi aynı satır dan devamke ");
            Console.Write(degisken);
            */

            /* temel mantık şu ilk writeline ı görene kadar srıasi ile basr (gelen write te olsa writlin de olsa )
             aynı ardından gelen bi öncesine göre iş yapar normal ve ln gelirse ikisi aynı satır ama 3 gelen normalde olsa ln de olsa alt satıra atar
             */


            // string için çift tırnak kullanılması gerekmektedir.
            // pythonda tek ve çift tırnak oluyor fakat tek tırnak c# ta 
            // karakter tanımalalamıza yarar

            // write ile writeline arasındaki fark vire ile gelenler hepsi sırası ile yazılır writeline gelenden sonra bir yeni satıra atlama durumu söz konusudur

            int a = 5;
            Console.WriteLine(a+"berkay");
            // python olsa virgül komyan lazım ama c# ta + koayabilirisin

            float aa = 135241;
            double bb = 645645645645411254635413541563413524135241.1;
            Console.WriteLine(bb);

            bool berkay = true;
            berkay = false;
            // pythonda 1 ve 0 diyede kullajnılarak true ve folsu otolatik alabiliyor fakata burada direk true yada fols olarak dönüş yapması gerekmektedriç.

            /*
                        for (int i = 0; ; i++)
                        {

                            Console.WriteLine("lütfen true yada false gir ");
                            bool giris = Convert.ToBoolean(Console.ReadLine());



                            if (giris == true)
                            {
                                Console.Clear();
                                Console.WriteLine("berkay akar giriş yaptı");
                                Console.WriteLine("Lütfen Çıkış için e ye bas");
                                giris = Convert.ToBoolean(Console.ReadLine());
                                if (giris==false)
                                {
                                    break;
                                }
                                else
                                {

                                }

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("giriş yapılamadıo keke");
                                break;
                            }


                        }

                        */


            // float ile double arasındaki fark dobule da . vardır ve daha fazla sayıyı içerisin alır
            // floatta virgül vardır ve deger olarak daha azdfır


            // solution exploerr kısmı birbirleri ile ilgili tüm projeleri içine koyduğumuz alandır.



        }
    }
}
