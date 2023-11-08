using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deklinirianjeDefiniranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, d = 0;

            Console.Write("Unsei vrijednost od a --> ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Unsei vrijednost od b --> ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Unsei vrijednost od c --> ");
            c = Convert.ToDouble(Console.ReadLine()); 
            
            Console.Write("Unsei vrijednost od d --> ");
            d = Convert.ToDouble(Console.ReadLine());

            double rez = a*a + b*b + c*c + d*d;
            double rez2 = (a + b) * (a + b) + (c * d) * (c * d);
            double x = rez / rez2;

            Console.WriteLine("Po matematickom izrazu rezultat je --> " + x);


            Console.ReadKey();
        }
    }
}
