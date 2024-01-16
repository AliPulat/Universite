using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5B.or_D2_
{
    internal class Program
    {
        static void Main(string[] args)
        {   satir:

            double inc ,s ,t;
            int kb,kk;
            inc = 2.54;
            string cinsiyet;

            Console.Write("Lütfen Cinsiyetinizi Giriniz erkek iseniz (E) veya (e),kadın iseniz (K) veya (k) olarak giriniz = ");
            cinsiyet = Console.ReadLine();

            Console.Write("Lütfen Boyunuzu Santim Cinsinden Giriniz = ");
            kb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lüftfen Kilonuzu Giriniz = ");
            kk = Convert.ToInt32(Console.ReadLine());

            s = (kb / inc);

            if (cinsiyet == "E"|| cinsiyet == "e")
            {
                 t = ((s - 60) * 2.3 + 50);
                if (kk == t)
                {
                    Console.WriteLine("İdeal Kilonuzdasınız = " + (int)t);
                }
                else if (kk < t)
                {
                   
                    Console.WriteLine("İdeal Kilonuzun Altındasınız = " + (int)t);
                }
                else if (kk > t)
                {
                    
                    Console.WriteLine("İdeal Kilonuzun Üstündesiniz = " + (int)t);
                }



            }

            else if (cinsiyet == "K" || cinsiyet == "k")
            {
                t = ((s - 60) * 2.3 + 45.5);
                if (kk == t)
                {
                    
                    Console.WriteLine("İdeal Kilonuzdasınız = " + (int)t);
                }

                else if (kk > t)
                {
                   
                    Console.WriteLine("İdeal Kilonuzun Üstündesiniz = " + (int)t);
                }

                else if (kk < t)
                {
                    
                    Console.WriteLine("İdeal Kilonuzun Altındasınız = " + (int)t);
                }
            }


            Console.ReadKey();
            goto satir;
           
        }
    }
}
