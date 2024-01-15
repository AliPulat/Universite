using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf92_odv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, a, e = 1;
            int[] B = new int[10];
            for(int i = 0; i < B.Length; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Giriniz = ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (a = 2; a < B.Length; a++)
            {
                if (Math.Abs(B[0] - B[a]) < Math.Abs(B[0] - B[e])) e = a;
            }
            Console.WriteLine("İlk Sayıya En Yakın Sayı = " + B[e]);
            Console.ReadKey();
        }
    }
}
