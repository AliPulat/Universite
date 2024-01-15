using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf91_odv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yüzler = { "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };

            int a;
            string s = null;
           

            Console.Write("Sayı Gir = ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a <= 999 && a > 0)
            {
                Console.Write("Doğru Sayı Girdiniz!");
                if(a / 100 > 1)
                {
                    s = Yüzler[a / 100 - 1];
                }
                if (a / 10 > 1)
                {
                    s = s + Onlar[a / 10 - 1];
                }
                if (a / 10 == 1)
                {
                    s = s + Onlar[a / 10 - 1];
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
