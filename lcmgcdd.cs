using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiboLcmGcd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num");
            
            long num1 = Convert.ToInt64(Console.ReadLine());
            //string x=  fibo(num1);
            //Console.WriteLine(x);
            Console.WriteLine("Enter the num2");
            long num2 = Convert.ToInt64(Console.ReadLine());
            //long x = gcdEuclid_new(num1, num2);
            long x = lcm(num1, num2);
            Console.WriteLine(x);
            

        }
        public static string fibo(long num)
        {
            string x = "";
            long a = 0;
            long b = 1;
            long c = 0;
            if (num == 0 || num == 1)
            {
                x = "" + num;
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    x = x + b + "\t";
                }
            }
            return x;

        }
        public static long gcdEuclid(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return (gcdEuclid(b, a % b));
        }
        public static long gcdEuclid_new(long a, long b)
        {
            if (a == 0)
            {
                return b;
            }
            else if(b==0)
            {
                return a;

            }
            else if (a == b)
            {
                return a;
            } 


            else
            {
            return (gcdEuclid(b, a % b));
            }
        }
        public static long lcm(long a, long b)
        {
            long pro = a * b;
            long gcd = gcdEuclid_new(a, b);
            long lcm = pro / gcd;
            return lcm;

        }


    }
}
