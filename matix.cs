using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_add
{
    class Program
    {
        static void Main(string[] args)
        {
            //matrix
            int n =Convert.ToInt32(Console.ReadLine());
            int[,] ma1 = new int[, ] {{1, 2},{ 5, 4}};
            int[,] ma2 = new int[,] {{ 8, 9},{ 5, 7}};
            int[,] ans=new int[2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ans[i, j] = ma1[i, j] + ma2[i, j];
                    Console.Write(ans[i, j] + "\t");
                }
            }
            foreach (var d in ans)
            {
                Console.WriteLine(d);  
            }
        }
    }
}
