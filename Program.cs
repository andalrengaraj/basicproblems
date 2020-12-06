using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprint2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Getint("Enter the num");
            // print1(num);
          ///  print1_1(num);
            //print2(num);
           // print3(num);
           // print3_1(num);
         //   print3b(num);
          //  print3c(num);
          //  print3d(num);
           // print3e(num);
           // print3f(num);
          //  print3b(num);
          //  print4a(num);
           // print4b(num);
           // print4c(num);
          //  print4d(num);
           // print4e(num);
           // print4f(num);
            //print4g(num);

        }
        static public int Getint(string message)
        {
            Console.WriteLine("******Getting Input from user********");
            Console.WriteLine(message + ":");
            int tempvalue;
            if (!int.TryParse(Console.ReadLine(), out tempvalue))
            {
                return Getint("Please enter the valid Dint :");
            }
            return tempvalue;
        }

        public static void print1(int num)
        {
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        public static void print1_1(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
        }

        public static void print2(int num)
        {
            for (int row = 0; row < num; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < num; col++)
                    {
                        Console.Write(" #");

                    }
                }
                else
                {
                    for (int col = 0; col < num; col++)
                    {
                        Console.Write("# ");

                    }
                }
                Console.WriteLine();
            }
        }

        public static void print3(int num)
        {
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col<=row; col++)
                {
                    Console.Write("# ");
                }

                Console.WriteLine();
            }
        }
        
        public static void print3_1(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

        


        }

        public static void print3b(int num)
        {
            for (int i = num; i >=1; i--)
            {
                for (int j = 1;j<=i; j++)
                {
                    Console.Write("# ");

                }
                Console.WriteLine();
            }
        }

        public static void print3c(int num)
        {
            for (int i = 1; i<=num; i++)
            {
                for (int k = 1; k <i; k++)
                {
                    Console.Write(" ");
                }
                for (int j =i; j<=num; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
           
        }

        public static void print3d(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int k =1; k<=(num-i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
        }

        public static void print4a(int num)//how to give space
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write((char)(count + 96));
                }
                Console.WriteLine();
            }
        }

        public static void print4b(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static void print4c(int num)
        {
            int count = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(count+"\t");
                    count++;
                    
                }
                Console.WriteLine();
            }
        }

        public static void print3e(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= num; col++)
                {
                    if (row==num||row==1||col==1)
                    {
                        Console.Write("# ");
                    }
                    

                }
                Console.WriteLine();
            }
            
        }

        public static void print3f(int num)
        {
            for (int row  =1; row <= num; row++)
            {
                for (int col = 1; col <=num; col++)
                {
                    if (row==num||row==1)
                    {
                        Console.Write("# ");
                    }
                
                 }
                Console.WriteLine();

            }
                
            }

        public static void print3b_1(int num)
        {
            for(int row=num;row>=1;row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("# ");

                }
                Console.WriteLine();
                }
        }

        public static void print4d(int num)
        {
            for (int i = 1; i<= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = num-1; 1<=i; i--)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void print4e(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }
            for (int i = num - 1; 1 <= i; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }
        }

        public static void print4f(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write((char)(96+count));
                    
                   
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(97+count));
                    count++;
                }
                Console.WriteLine();
            }

                   }

        public static void print4g(int num)
        {
            int count = 00;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write(count+"\t");
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + i +"\t");
                    count++;
                }
                Console.WriteLine();
            }
        }





        }
    }
    

