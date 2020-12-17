using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ballon_input_1
{
    class Program
    {
        //GETTING INPUT FORM A TEXT FILE AND RETURN THE OUTPUT IN A TEXT FILE.
        static void Main(string[] args)
        {
            //Create a stream reader where to read
            StreamReader reader = new StreamReader("C:\\MySample\\ballon_input.txt");
            Console.SetIn(reader);

            //where to wwrite the output
            StreamWriter writer = new StreamWriter("C:\\MySample\\ballon_output.txt");
            Console.SetOut(writer);

            int no_of_test_case = int.Parse(Console.ReadLine());
            for (int i = 1; i <= no_of_test_case; i++)
            {
                string[] ballon_cost = (Console.ReadLine().Split(' '));
                int green_cost = int.Parse(ballon_cost[0]);
                int purple_cost = int.Parse(ballon_cost[1]);

                int no_of_particicpants = int.Parse(Console.ReadLine());
                int green_sum = 0;
                int purple_sum = 0;
                for (int j = 1; j <= no_of_particicpants; j++)
                {
                    string[] par = (Console.ReadLine().Split(' '));
                    green_sum += int.Parse(par[0]);
                    purple_sum += int.Parse(par[1]);


                }
                int cost_max = largest_of_2(green_cost,purple_cost);

                int cost_min = smallest_of_2(green_cost, purple_cost);
                int count_max = largest_of_2(green_sum, purple_sum);
                int count_min = smallest_of_2(green_sum, purple_sum);
                int ans = cost_max *count_min;
                int ans_1 = cost_min *count_max;
                Console.WriteLine(ans+ans_1);
                
                



            }
            reader.Close();
            writer.Close();





           
        }
        static public int smallest_of_2(int num1, int num2)
        {

            if (num1 > num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }

        }
        static public int largest_of_2(int num1, int num2)
        {

            if (num1 < num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }

        }

    }
}
