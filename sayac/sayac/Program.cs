using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte db = 9;
            byte dko = 5;

            byte sb = 9;
            byte so = 5;

            bool kronometre = true;

            while (kronometre)
            {
             for ( ; dko >= 0; dko--)
             {
              for ( ; db >= 0; db--)
              {
               for ( ; so >= 0; so--)
               {
                 for ( ; sb >= 0; sb--)
                 {
                  Console.WriteLine(dko.ToString() + db.ToString() + "." + so.ToString() + sb.ToString());
                  System.Threading.Thread.Sleep(1000);
                  Console.Clear();
                 }
                sb = 9;
               }
               so = 5;
              }
              db = 9;
             }
                kronometre = false;
            }

            Console.ReadKey();
        }
    }
}
