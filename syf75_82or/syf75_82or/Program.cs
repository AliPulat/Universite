using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf75_82or
{
    internal class Program
    {
        static void Main(string[] args)//BUNU BU ŞEKİLDE METOTLA YAZ DİYE KLASİK SORABİLİR 
        {
            Console.Write("LÜtfen ilk sayıyı giriniz = ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen Son Sayıyı Girinzi = ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            for(int i = s1; s1 <= s2; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine("3 e bölümünden kalan sayılar = {0}", i);
                }
            }





            Console.ReadKey();



        }

           






        }
    }
}
