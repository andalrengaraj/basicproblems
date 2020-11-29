using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ans= round_sum_1(1282);
            //Console.WriteLine(ans);

        //// string ans=   last_att(510);
        // Console.WriteLine(ans);

            string ans = current(54321);
            Console.WriteLine(ans);
         

        }
        static public string RoundSum(int num1)
        {
            string x = "";
            double num = Convert.ToDouble(num1);
            int count = 1;

            double mod = 0; 
            
            double tenbase = Math.Pow(10, count);
            while ( num>tenbase)
            {
               mod = num % tenbase;
          
        

               x = x + mod + "\t";
  
                
                num = num-mod;

                
               
                count++;
            }
            return x;



        }
        static public string round_sum_1(double num)
        {
            string x = "";
            double mod = 0;
            int count = 1;
            double mod_by = Math.Pow(10, count);

            while (num > mod_by)
            {

                mod = num % mod_by;
                x = x + mod + "\n";

                num = num - mod;
                count++;
            }

            return x;
           
        }
      

        static public string current(int num)
        {
            string x = "";
            int pow = 0;
            double count = 0;
            
            int current=1;
            while(num!=0)
            {

                current = num % 10;
                count = Math.Pow(10, pow);
                x = x + current *count+ "\n";
                pow++;
                
                num = num / 10;
                

            }
            return x;
        }

    }
}
