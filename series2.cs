using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series2__
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine();
                int len = input.Length;
               // Console.WriteLine(len);

                int n = Convert.ToInt32(input) % 10;
               // Console.WriteLine(n);
                if (input == "1" || input=="0")
                {
                    Console.WriteLine(input);
                }

                else if (len == 1)
                {
                    int ans = (Convert.ToInt32(input) - 1);
                    //Console.WriteLine(ans);

                    Console.WriteLine(ans + "1");

                }
                else if (len == 2)
                {
                    int ans = 10 * (n - 1) + 3;
                    Console.WriteLine(ans);

                }
                else if (len == 3)
                {
                    int ans = (10 * (n - 1)) + 6;
                    Console.WriteLine(ans);
                }
                else if (len == 4)
                {
                    int ans = (10 * (n - 1)) + 10;
                    Console.WriteLine(ans);
                }
            }
            
            

          



        }
                   


        }
    }

                 
    

