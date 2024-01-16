using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf81_odv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Öyle bir program yazın ki, önce kullanıcıya kaç adet sayı girmek istediğini sorsun. Daha sonra kullanıcıdan sayı 
            girmesini istesin. Kullanıcı fark etse de etmese de baştan girdiği adet kadar sayı tamamlandığında bu sayıların toplamını
            ve ortalamasını hesaplayarak ekrana yazsın.*/

            Console.Write("Lütfen Kaç Adet Sayı Giriceğiniz Yazınız = ");
            int adt = Convert.ToInt32(Console.ReadLine());

            double ort = 0;
            int toplam = 0; 
            for (int i = 0; i < adt; i++)
            {
               
                Console.Write("\n Sayı gir = ");
                int sy = Convert.ToInt32(Console.ReadLine());

                
                toplam += sy;
                ort = toplam / adt;
                Console.WriteLine("\n toplam = " + toplam);
                Console.WriteLine("\n ortalama = " + ort);


            }

            Console.ReadKey();

        }
    }
}
