using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int a = Convert.ToInt16(inputs[0]);
            int b = Convert.ToInt16(inputs[1]);
            int c = Convert.ToInt16(inputs[2]);
           
            if (c == 1)
            {
                while (a >=0 || b>= 0)
                {
                    b = b - 1;
                   
                    if (b == -1)
                    {
                        Console.WriteLine("Takahashi");
                        break;
                    }
                      a = a - 1;
                    if (a == -1)
                    {
                        Console.WriteLine("Aoki");
                        break;
                    }
                    
                }
            }
            else  if (c == 0)
            {
                while (a >= 0 || b >= 0)
                {
                    a = a- 1;
                  
                    if (a == -1)
                    {
                        Console.WriteLine("Aoki");
                        break;
                    }
                    b = b - 1;
                    if (b == -1)
                    {
                        Console.WriteLine("Takahashi");
                        break;
                    }
                  
                }
            }

        }
    }
}
