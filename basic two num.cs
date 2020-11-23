using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double r = Convert.ToDouble(Console.ReadLine());
            double perimeter = call_perimeter(r);
            Console.WriteLine(perimeter);


        }
      static public double call_perimeter(double r)

       {
          return 2*Math.PI*r;

       }
    }
}
