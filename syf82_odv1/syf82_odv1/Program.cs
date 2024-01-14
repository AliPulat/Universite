using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf82_odv1
{
    internal class Program
    {
        static void Main(string[] args)
        {//aldığı burs 500TL altında olanlara %10 ve +50 TL sabit artış yapan program!
         //burs miktarları a dizi değişkeninde saklanıyor! foreach ile yapımı 

            double[] burs = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };
            

            foreach (double a in burs)
            {
               
                if(a >= 500)
                {
                    Console.WriteLine("\n Zam'a tabi olmayan burs fiyatları = " + a);
                    continue;
                }

                double islem = (a * 0.1) + a;
                islem += 50;
                Console.WriteLine("\n Zam Alanların Yeni Maaşı = " + islem);
            }
            Console.ReadKey();
        }
    }
}
