using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace df
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "No";
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int n = Convert.ToInt32(inputs[0]);
            int s = Convert.ToInt32(inputs[1]);
            int d = Convert.ToInt32(inputs[2]);
            for (int i = 0; i < n; i++)
            {
                string x_yin = Console.ReadLine();
                string[] inputsxy = x_yin.Split(' ');
                int x = Convert.ToInt32(inputsxy[0]);
                int y = Convert.ToInt32(inputsxy[1]);
                if (x < s && y > d)
                {
                    ans="Yes";
                    break;
                }
                
                  
            }
            Console.WriteLine(ans);
        }
    }
}
