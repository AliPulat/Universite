using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf79_odv
{
    internal class Program
    {
        static void Main(string[] args)
        {//ikili sayı değerini klavyeden girilecek şekilde yeniden programlayınız 
            int sayi;
            int ikiliDeger;
            int onluDeger = 0;
            int tabanDeger = 1;
            int basamakDeger;
            bastan:
           
            Console.Write("\n Lütfen 2'lik Sayı Sistemine Uyan Sayı Yazınız = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            
            ikiliDeger = sayi;


            while (sayi > 0)
            {
                basamakDeger = sayi % 10;
                onluDeger = onluDeger + basamakDeger * tabanDeger;
                sayi = sayi / 10;
                tabanDeger = tabanDeger * 2;
            }
            Console.Write("İkili  Sayı Değeriniz : " + ikiliDeger);
            Console.Write(" \n Onlu  Sayı Değeriniz : " + onluDeger);

            goto bastan;
            Console.ReadKey();
        }
    }
}
