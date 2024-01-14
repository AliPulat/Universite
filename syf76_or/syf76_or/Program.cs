using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf76_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Öyle bir program yazın ki kullanıcıdan bir sayı istesin.Daha sonra bu sayı ile 1 arasındaki TEK veya ÇİFT
            tamsayıların toplamını hesaplayarak sonucu ekrana yazsın. Kullanıcıya TEK veya ÇİFT tamsayılar ile ilgili işlem
            yapılacağını sorsun?
            Bir sayı girin:
            TEK’leri mi ÇİFT’leri mi toplamak istersiniz?*/

            int toplam = 0;
            Console.Write("Lütfen Başlangıç Sayıyı Yazınız = ");
            int say1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("lütfen Bitiş Sayısı Yazınız= ");
            int say2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("lütfen Tek'mi Çift'mi Toplamak istediginizi Belirtinzi = ");
            string istek = Console.ReadLine();

            for(int i = say1; i <= say2; i++)
            {
                if((istek == "çift" && i % 2 == 0) || (istek == "tek" && i % 2 == 1))
                {
                    toplam += i;
                }
            }
            if (istek == "çift")
            {
                Console.Write("Girilen Değer Aralıgı Çift Sayıları Toplamı = " + toplam);
            }

            else if (istek == "tek")
            {
                Console.Write("Girilen Değer Aralıgı Tek Sayıları Toplamı = " + toplam);
            }

            Console.ReadKey();






        }
    }
}
