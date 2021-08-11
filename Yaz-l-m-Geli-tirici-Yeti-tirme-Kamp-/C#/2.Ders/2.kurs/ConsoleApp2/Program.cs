using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Döngüler :  kare .. lar olması gerekmektedir.
            int a = 1;
            a++;
            Console.WriteLine(a);
   
            /*
            for (int i = 0; i < 100; i++)
            {
                

            }
            for (int i = 0; i < 100; i=i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            for (int i = 0; i < 100; i = i += 4)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */

            // dizi
            
            string kurs_1 = "java";

            string kurs_2 = "C#";

            string[] dizi = new string[] { kurs_1,kurs_2};


            // dizilerda farklı eleman tipleri olmaz hespi int sitrng yada double gbi olmalıdır


            /*
            for (int i = 0; i < dizi.Length; i++)
            { 
                Console.WriteLine(i+". eleman : "+dizi[i]);
            }



            Console.ReadKey();


            */



            /*
            for (int i = 0; i < 2 ; i++)
            {
                dizi[i] = kurs_1;
            }

            for (int i = 0; i < i; i++)
            {
                Console.WriteLine(dizi[i]);
                Console.ReadKey();
            }
            
            */


            // Foreach döngüsü keke

            foreach (var item in dizi)  // dizi içerisinde gezer
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
