using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehirler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sehirler = { "Adana", "Malatya", "Ankara", "Bursa", "Edirne", "Kastamonu", "Batman", "Sinop", "Ankara", "Ordu", "Ankara", "Samsun", "Mersin" };
            Console.WriteLine("Bir şehir giriniz:");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;
            int counter = 0;
            Console.Write("\nArrayin");
            string sehirlerinTamamı = string.Empty;
            for (int i = 0; i < sehirler.Length; i++)
            {
                sehirlerinTamamı += $"{i}.{sehirler[i]}\n";
                if (sehirler[i] == girilenSehir)
                {
                    Console.Write(" " + i);
                    counter++;
                    varMi = true;
                }
            }
            if (varMi)
            {
                if (counter > 1)
                    Console.WriteLine($". indekslerinde {girilenSehir} var.");
                else
                    Console.WriteLine($". indeksinde {girilenSehir} var.");
                Console.WriteLine("\nArray : \n--------\n" + sehirlerinTamamı);
            }
            else
            {
                Console.WriteLine($" içinde {girilenSehir} yok.");
                Console.WriteLine("\nArray : \n--------\n" + sehirlerinTamamı);
            }
            Console.ReadKey();
        }
    }
}