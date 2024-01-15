using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf91_odv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

            byte a;
            string s = null;

            Console.Write("Sayı Gir = ");
            a = Convert.ToByte(Console.ReadLine());

            if(a <= 99 && a > 0)
            {
                Console.Write("Doğru Sayı Girdiniz!");

                if (a / 10 > 1)
                {
                    s = Onlar[a / 10 - 1];
                }
                if (a / 10 == 1)
                {
                    s = Onlar[a / 10 - 1];
                }
                if (a % 10 != 0)
                {
                    s = s + Birler[a % 10 - 1];
                }

            }
            else
            {
                Console.Write("Hatalı Sayı Girdiniz!");
            }
           
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
