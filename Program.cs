using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compound1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principle:");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate:");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time in years");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the n");
            double n= Convert.ToDouble(Console.ReadLine());

            double rate1 = rate / 100;
            double pow1=n*time;
            double cal = (1 + (rate1 / n));
            double total = Math.Pow(cal, pow1);
            double CI = principal * total;
            Console.WriteLine("The CI is :" + CI);

            
            
        }
    }
}
