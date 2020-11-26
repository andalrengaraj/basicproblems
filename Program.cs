
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grosspay1
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the basic pay:");
            double basicpay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the DA%:");
            double DA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the TA%:");
            double TA = Convert.ToDouble(Console.ReadLine());


            double TA1 =  basicpay * TA / 100;
            double DA1 = basicpay * DA / 100;
            double PF = basicpay * 0.08;
            double grosspay = ((basicpay + TA1 + DA1)-PF);
          
            Console.WriteLine("The gross pay is :" + grosspay);

            

        }
    }
}
