using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Araçınızı Giriniz(Kamyon/Otomobil/İş Makinesi) = ");
            string arac = Console.ReadLine();

            Console.Write("Park Süresini Giriniz = ");
            int ps = Convert.ToInt32(Console.ReadLine());


            double para = 0;
            int gun = (ps / 24);
            int saat = (ps % 25);


            if(arac == "Otomobil")
            {
                if(ps <= 0) { Console.WriteLine("Hatalı Sayı Girdiniz"); }

                else if (ps <= 2)
                {
                    para = 5;
                    Console.WriteLine("0-2 Saat Arası Ücret = {0}", para);
                }
                else if (ps > 2 && ps <= 10)
                {
                    para = ((ps - 2) + 5);
                    Console.WriteLine("{0}. Saat Araç Ücreti = {1}", ps, para);
                }
                else if (ps <= 11 && ps <= 24) { Console.WriteLine("8 Saat Üstü Ücret Sabittir 18 TL'dir"); }
           


                if(ps > 24)
                {
                    if(saat <= 2)
                    {
                        para = ((gun * 13) + (saat * 5));
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                    else if (ps > 2 && ps <= 10)
                    {
                        para = (gun * 13) + (saat - 2) + 5;
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                    else if(ps >= 11 && ps <= 24)
                    {
                        para = ((gun * 13) + 13);
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                }
            }




            else if (arac == "Kamyon")
            {
                if (ps <= 0) { Console.WriteLine("Hatalı Sayı Girdiniz"); }

                else if (ps <= 2)
                {
                    para = 8;
                    Console.WriteLine("0-2 Saat Arası Ücret = {0}", para);
                }
                else if (ps > 2 && ps <= 8)
                {

                    para = ((ps - 2) * 2 + 8);
                    Console.WriteLine("{0}. Saat Araç Ücreti = {1}", ps, para);
                }
                else if (ps <= 11 && ps <= 24)
                {
                    Console.WriteLine("10 Saat Üstü Sabit Ücrettir 20 Tl");
                }



                if (ps > 24)
                {
                    if (saat <= 2)
                    {
                        para = (saat * 8) + (gun * 20);
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                    else if(ps > 2 && ps <= 8)
                    {
                        saat = (saat - 2);
                        para = ((gun * 20) + (saat * 8) + 8);
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                    else if (ps >= 8 && ps <= 24)
                    {
                        para = (gun * 20) + 20;
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                }               
            }


            if(arac == "İş Mankinesi")
            {
                if (ps <= 0) { Console.WriteLine("Hatalı Sayı Girdiniz"); }

                else if(ps <= 2)
                {
                    para = 12;
                    Console.WriteLine("0-2 Saat Arası Ücret = {0}", para);
                }
                else if(ps < 2 && ps <= 8)
                {
                    ps = ps - 2;
                    para = ((ps * 3) + 12);
                    Console.WriteLine("{0}. Saat Araç Ücreti = {1}", ps, para);
                }
                else if (ps >= 11 && ps <= 24)
                {
                    Console.WriteLine("Sabit Ücret 50 Tl'dir");
                }


                if(ps > 24)
                {
                    if(saat <= 2)
                    {
                        para = ((gun * 50) + 12);
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                    else if(saat > 2 && saat <= 8)
                    {
                        saat = saat - 2;
                        para = (saat * 3) + (gun * 50) + 12;
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                    else if (saat > 8 && saat <= 24)
                    {
                        para = (50 + (gun * 50));
                        Console.WriteLine("{0} gün {1} saat kalan araç ücreti = {2}", gun, saat, para);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
