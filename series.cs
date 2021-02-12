using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series2
{
    class Program
    {
        static void Main(string[] args)
        {
                
                string inputs = Console.ReadLine();
                string[] input= inputs.Split(' ');
                int a = Convert.ToInt32(input[0]);
                int b = Convert.ToInt32(input[1]);
                int x = (a + b) / 2;
                int y = x-b;
                //Console.WriteLine(x);
                //Console.WriteLine(y);
                Console.WriteLine("{0} {1}",x,y);

                

                
            
               
           
            
               
                
               
            
            
            
        }
    }
}
