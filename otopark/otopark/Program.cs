using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark
{
    internal class Program
    {
        static void Main(string[] args)
        {
        satir:
            int s1, arts1;
            string Aracturu;

            Console.Write("Lütfen Arac Türünü seçin = ");
            Aracturu = Console.ReadLine();

        ml:
            Console.Write("Lütfen bir Saat Giriniz = ");
            s1 = Convert.ToInt32(Console.ReadLine());


            if (Aracturu == "O")
            {
                if (s1 <= 0)
                {
                    Console.WriteLine("hatalı sayı girdiniz");
                    goto ml;
                }
                else if (s1 <= 2)
                {
                    Console.WriteLine("0-2 Saat Arası Ücret 5 TL'dir");
                }
                else if (s1 <= 9)
                {
                    arts1 = (3 + s1++);
                    Console.WriteLine("2-9 Saat Arası Ücret = " + " " + arts1);
                }
                else if (s1 >= 10)
                {
                    Console.WriteLine("10 Saat Üstü Ücret Sabit 13 TL'dir");
                }


            }





            else if (Aracturu == "K")
            {
                if (s1 <= 0)
                {
                    Console.WriteLine("HAtalı Sayı Girdiniz");
                    goto ml;
                }

                else if (s1 <= 2)
                {

                    Console.WriteLine("0-2 Saat Arası Ücret 8 TL'dir");
                }
                else if (s1 <= 7)
                {

                    arts1 = ((s1 - 2) * 2 + 8);
                    Console.WriteLine("2-7 Saat Arası Ücret = " + " " + arts1);
                }
                else if (s1 >= 8)
                {
                    Console.WriteLine("8 Saat Üstü Ücret Sabittir 20 TL'dir ");
                }

            }


            else if (Aracturu == "M")
            {
                if (s1 <= 0)
                {
                    Console.WriteLine("sıfırdan küçük değer girdiniz");
                    goto ml;
                }
                else if (s1 <= 2)
                {
                    Console.WriteLine("0-2 Saat Arası Ücret 12 TL'dir ");
                }
                else if (s1 <= 7)
                {
                    arts1 = ((s1 - 2) * 3 + 12);
                    Console.WriteLine("2-7 Saat Arası Ücretimiz = " + " " + arts1);
                }
                else if (s1 >= 8)
                {
                    Console.WriteLine("8 Saat Ve Üstü Ücret Sabitti 30 TL'dir ");
                }

            }
            Console.ReadKey();
            goto satir;
        }
    }
}
