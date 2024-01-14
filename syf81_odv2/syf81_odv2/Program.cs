using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf81_odv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yukarıdaki örneği b değeri kullanıcı tarafından girilecek şekilde düzenleyiniz.

            Console.Write("Bir sayı girin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int a;
            String s = "Sayı Asal Sayı";

            if (b == 1)
            {
                Console.WriteLine("ASAL DEĞİL!");
                goto bitir;
            }

            for (a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "Sayı Asal Sayı Değil!";
                    break;
                }
            }

            
            Console.WriteLine(s);
            bitir: Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
