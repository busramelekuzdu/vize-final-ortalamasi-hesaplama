using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int vize, final;
                double sonuc;
                Console.Write("Vize notunu giriniz:");
                vize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Final notunuz:");
                final = Convert.ToInt32(Console.ReadLine());

                sonuc = final * 0.7 + vize * 0.4;

                if (sonuc > 0 && sonuc < 54)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı F1");
                if (sonuc > 55 && sonuc < 59)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı D1");
                if (sonuc > 60 && sonuc < 64)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı C2");
                if (sonuc > 65 && sonuc < 69)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı C1");
                if (sonuc > 70 && sonuc < 74)
                Console.WriteLine("ortamalanız " + sonuc + " not karşılığı B3");
                if (sonuc > 75 && sonuc < 79)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı B2");
                if (sonuc > 80 && sonuc < 84)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı B1");
                if (sonuc > 85 && sonuc < 89)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı A3");
                if (sonuc > 90 && sonuc < 94)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı A2");
                if (sonuc > 95 && sonuc < 100)
                Console.WriteLine("ortalamanız " + sonuc + " not karşılığı A1");

                Console.ReadLine();

            }
        }
    }