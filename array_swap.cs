using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_swap_rotate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] myarr = generatearray(n);
            //printarray(myarr);
            #region  1 swap two
            //int i1 = Convert.ToInt32(Console.ReadLine());
            //int i2 = Convert.ToInt32(Console.ReadLine());
            
            
            //    int temp = 0;
            //    temp = myarr[i1];
            //    myarr[i1] = myarr[i2];
            //    myarr[i2] = temp;
            
            //printarray(myarr);
            #endregion

            #region 2 ascending order or not
            //int[] myarr = new int[] { -100,-1,0,3,10,20,100,900 };
            //string ans = "no";
            //int i=0;
            //while(myarr[i]!=myarr.Last())
            //{
                
            //    if (myarr[i] < myarr[i + 1])
            //    {

            //        ans = "yes";
            //    }
            //    else
            //    {
            //        ans = "no";
            //        break;
            //    }
            //    i++;
                
            //}
            
            //Console.WriteLine(ans);
            #endregion

            #region 64 two array are same
            //int[] ma1 = generatearray(n);
            //printarray(ma1);
            //int[] ma2 = generatearray(n);
            //printarray(ma2);
            //bool result = issame(ma1, ma2);
            //Console.WriteLine(result);
            #endregion

            #region 65 reverse array
            //int[] reverse_ans = reverse(myarr);
            //printarray(reverse_ans);


            #endregion

            #region 67 identical
           // int[] ma1 = new int[]{1,2,3,4};
           // printarray(ma1);
           // //Console.WriteLine("n1");
           //// int n1 = Convert.ToInt32(Console.ReadLine());
           // int[] ma2 = new int[] { 1, 2, 3, 4, 7, 4, 10 };
           // printarray(ma2);
           // int ans = sameindices(ma1, ma2);
           // Console.WriteLine(ans);
            #endregion

            #region 68 duplicate
            int[] myarr = new int[] { 1, 10, 2, 1, 5, 1};
            printarray(myarr);
            removeduplicate(myarr);
           // Console.WriteLine(duplicate);

            #endregion



        }
        public static bool issame(int[] ma1, int[] ma2)
        {
            bool ans = false;
            for (int i = 0; i < ma1.Length; i++)
            {
                if (ma1[i] == ma2[i])
                {
                    ans = true;

                }
                else
                {
                    ans = false;
                    break;
                }
            }
            return ans;
        }

        public static int[] reverse(int[] ma1)
        {
            int[] revarr = new int[ma1.Length];
            int j = 0;
            for (int i = ma1.Length-1;i>=0 ; i--)
            {
               // Console.WriteLine(ma1[i]);
                revarr[j] = ma1[i];
                //Console.WriteLine(revarr[j]);
                j++;
                



            }
            return revarr;
           

            
        }

        public static int sameindices(int[] ma1, int[] ma2)
        {
            int ans = -1;
            if (ma1.Length > ma2.Length)
            {
                for (int i = 0; i < ma2.Length; i++)
                {
                    if (ma1[i] == ma2[i])
                    {
                        ans = i;
                        // Console.WriteLine(i);
                    }
                    else
                    {
                        break;
                    }
                   
                }
            }
            else if (ma1.Length < ma2.Length)
            {
                for (int i = 0; i < ma1.Length; i++)
                {
                    if (ma1[i] == ma2[i])
                    {
                        ans = i;
                        // Console.WriteLine(i);
                    }
                    else
                    {
                        break;
                    }
                   
                }
            }
            return ans;
        }

        public static void removeduplicate(int[] ma)
        {
            
            for (int i = 0; i < ma.Length; i++)
            {
                int count = 0;
               
                    for (int j = i + 1; j < ma.Length; j++)
                    {
                        
                        if (ma[i] == ma[j])
                        {
                            count++;

                        }
                        
                    }
                    Console.WriteLine("the count of {0},{1}", ma[i], count);
      
            }
           
                      
        }






        public static int[] generatearray(int n)
        {
            int[] ma = new int[n];
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                
                ma[i] = random.Next(1,100);
                
            }
            return ma;
            

        }

        public static void printarray(int[] ma)
        {
            foreach (var d in ma)
            {
                Console.Write(d+"\t");
            }
            Console.WriteLine();
        }

        
    }
    
}
