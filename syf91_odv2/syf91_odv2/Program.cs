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
             string[] birler = { null,"Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
             string[] onlar = { null,"On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
             string[] yuzler = { null,"yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };


             for(int i = 0; i <= 3; i++)
             {
                 satir:
                 Console.Write("\n Lütfen Bir Sayı Giriniz = ");
                 int gsayi = Convert.ToInt32(Console.ReadLine());

                 if(gsayi <= 999 && gsayi >= 0)
                 {
                     int a = (gsayi / 100); //yüzler
                     int b = (gsayi / 10) % 10; // onlar
                     int c = (gsayi % 10); // birler

                     Console.WriteLine("Girilen Sayımızın Yazlılışı = " + yuzler[a] + onlar[b] + birler[c]);
                 }

                 else
                 {
                     Console.Write("Hatalı Sayı Giriniz Lütfen Tekrar Deneyin");
                     goto satir;
                 }
             }

            Console.ReadKey();
        }
    }
}
