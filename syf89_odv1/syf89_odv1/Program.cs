using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syf89_odv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };

            
            int enYuksekNot = -1;
            int enDusukNot = 120;

            for (int i = 1; i < B.Length; i++)//yüksek düşük 
            {
                if (B[i] > enYuksekNot)
                {
                    enYuksekNot = B[i];
                }

                if (B[i] < enDusukNot)
                {
                    enDusukNot = B[i];
                }
            }

            
            Console.WriteLine($"En yüksek not: {enYuksekNot}");
            Console.WriteLine($"En düşük not: {enDusukNot}");

            Console.WriteLine("En yüksek notu alan öğrenciler:");
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == enYuksekNot)
                {
                    Console.WriteLine(A[i]);
                }
            }

            Console.WriteLine("En düşük notu alan öğrenciler:");
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == enDusukNot)
                {
                    Console.WriteLine(A[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
