using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_linear
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetInterger("ENter the n");


            Random random = new Random(DateTime.Now.Millisecond);


            



            


            //int x = GetInterger("Enter the x");
            //int k = GetInterger("Enter the k");
            //int res = q_40(ma, x, k);
            //Console.WriteLine(res);
            #region Target value present or not
            //int[] ma = new int[] { 1, 2, 3, 4, 12, 65, 22, 84 };
            //print_array(ma);
            //int x = GetInterger("Enter the x");
            //bool ans = q_11(ma, x);
            ////first_sec_largest(ma);
            //Console.WriteLine(ans);
            #endregion

            #region Target value return its index
            //int[] ma = new int[] { 1, 2, 3, 4, 5, 64, 344 };
            //print_array(ma);
            //int x = GetInterger("Enter the x");
            //int ans = q_22(ma, x);
            //Console.WriteLine(ans);
             #endregion

            #region Target value find if it is repeated
            //int[] ma = new int[] { 1, 2, 3, 4, 5, 64, 344 ,64};
            //print_array(ma);
            //int x = GetInterger("Enter the x");
            ////int start = GetInterger("ENter the start");
            //bool ans = q_3(ma, x);
            //Console.WriteLine(ans);
            #endregion

            #region Target value find if it is repeated second time,give the index
            //int[] ma = new int[] { 1, 2, 3, 4, 5, 64, 344, 64, 64 };
            //int x = GetInterger("Enter the x");
            //int ans = q_4(ma, x);
            //Console.WriteLine(ans);
            #endregion

            #region no_of_times x occurs
            //int[] ma = new int[] { 1, 3, 5, 7, 9, 10, 15, 18, 100,10,10,10};
            //int x = GetInterger("Enter the x to be checked");
            //int ans = q_6(ma, x);
            //Console.WriteLine(ans);
            #endregion

            #region give indices
            //int[] ma = new int[] { 12, 14, 65, 55, 66, 76, 43, 56, 24, 55, 55 };
            //int x = GetInterger("Enter the value for x");
            //string ans = q_42(ma, x);
            //Console.WriteLine(ans);

            #endregion

            #region 
            //int[] ma = new int[] {12,13,14,12};
            //print_array(ma);
            //int x = GetInterger("Enter the x");
            //int[] ans = q_43(ma, x);
            //print_array(ans);
            
            #endregion

            #region 44
            //int[] ma = new int[] {1,3,4,5,6,7,8 };
            //print_array(ma);
            //int x = GetInterger("Enter the number to be inserted");
            //int loc = GetInterger("Enter the loc where x to be inserted");
            //int[] ans = q_44(ma, x, loc);
            //print_array(ans);
            #endregion

            #region 45
            //int[] ma = new int[] { 1, 22, 23, 54, 55, 56 };
            //print_array(ma);
            //int loc = GetInterger("Enter the loc elements to be removed");
            //int[] ans = q_45(ma, loc);
            //print_array(ans);
            #endregion

            #region 46
            //int[] ma = new int[] { 12, -2, 23, 43, 54, 67, -100 };
            //print_array(ma);
            //int ans = q_46_2(ma);
            //Console.WriteLine(ans);

        
            #endregion

            #region 47
            //int[] ma = new int[] { 12,-3, -2, 23, 43, 54, 67, 1 };
            //print_array(ma);
            //int ans = q_47_small(ma);
            //Console.WriteLine(ans);
            #endregion

            #region 48
            //int[] ma = new int[] { 22, 26, 89, 45, 11, 01, 87, -100, 89 };
            //print_array(ma);
            //int ans = q_48(ma);
            //Console.WriteLine(ans);

            #endregion

            #region 49
            //int[] ma = new int[] { 1, 2, 3, 4, 76, 095, 100, 8777 };
            //print_array(ma);
            //int ans = q_49_large(ma);
            //Console.WriteLine(ans);
            #endregion

            #region 50 51
            //int[] ma = new int[] { 12, 13, 23, 45, 44, 77, 900 ,76895};
            //print_array(ma);
            //int first_large = q_49_large(ma);
            //int[] arr = q_45(ma, first_large);
            //int second_large = q_49_large(arr);
            //Console.WriteLine("First large value :{0}",+first_large);
            //Console.WriteLine("Second large value:{0} ",+second_large);

            
            #endregion

            #region 52
            //int[] ma = new int[] { 0,0,0,0,10,10,100 };
            //print_array(ma);
            //int first_large = q_49_large(ma);
            //int[] arr = q_45(ma, first_large);
            //int second_large = q_49_large(arr);
            //int product = first_large * second_large;
            //Console.WriteLine(product);
            #endregion

            #region 53
            //int[] ma = new int[] { 1, 2, 3, 22, 33, 44, 56, 45, 45, 100, 45, 100, 45,1000 };
            //print_array(ma);
            //int large = q_49_large(ma);
            //Console.WriteLine(large);
            //int ans = q_53_timeslarge(ma);
            //Console.WriteLine("The number of times larger value present is :{0}",ans);
           
            #endregion

            #region 54
            //int[] ma = new int[] { 1, 2, 3, 22, 33, 44, 56, -45, -45, 100, -45, 100, -45, 1000 };
            //print_array(ma);
            //int small = q_46_small(ma);
            //Console.WriteLine(small);
            //int ans = q_54_timessmall(ma);
            //Console.WriteLine("The number of times larger value present is :{0}", ans);
           
            #endregion

            #region 56
            //int[] ma = new int[] { 2, 3, 4, 7, 8, 9, 10 };
            //print_array(ma);
            //int min_range = GetInterger("Enter the min range");
            //int max_range = GetInterger("Enter the max range");
            //int ans = q_56(min_range, max_range, ma);
            //Console.WriteLine(ans);
            #endregion

            #region 57
            //int[] ma = new int[] {1,2,3,4,5,5,7,7,9};
            //print_array(ma);
            //int count = 0;
            //for (int j = 0; j < ma.Length; j++)
            //{
            //    int ans = q_57(ma, j);
            //   /// Console.WriteLine(ans);
            //    if (ans == 1)
            //    {
            //        Console.WriteLine(ma[j]);
            //        count++;
            //    }

            //}
          
            #endregion

            #region 58
            //int[] ma = new int[] {9,8,7,5,4,3,2,1,2,3,4,6,6,5,3,2,6,6,3,2,6,8,8,6};
            //print_array(ma);
            //int max_count = int.MinValue;
            //int res = -1;
            //for (int j = 0; j < ma.Length; j++)
            //{
            //     int ans=q_58(ma, j);
            //     if (ans > max_count)
            //     {
            //         max_count = ans;
            //         res = ma[j];

            //     }
                
                 

            //}
            //Console.WriteLine("The count of the most repeated element: {0}",max_count);
            //Console.WriteLine("The most repeated number in the array: {0}",res);
            #endregion

            #region 59
            //int[] ma = new int[] { 1,1,4,3,3,2,2,5,5,4,4,3,2};
            //print_array(ma);
            //int min_count = int.MaxValue;
            //int least_rep_num = 100;
            //for (int j = 0; j < ma.Length; j++)
            //{
            //    int ans = q_57(ma, j);
               
            //     if (ans < min_count)
            //    {
            //         min_count = ans;
            //        least_rep_num = ma[j];
            //    }
                 
            //}

            //Console.WriteLine("The least repeated number in the given array is : {0}",least_rep_num);
            //Console.WriteLine("The count of the min repeated number is : {0}", min_count);

            #endregion


            #region 60
            //int[] ma = new int[] { 1, 2, 3, 4, 5 ,9};
            //print_array(ma);
            //string x="";
            //for(int j=0;j<10;j++)
            //{
            //    int count_1=q_60(ma,j);
            //    if(count_1==0)
            //    {
            //        x = x + j + "\t";
            //    }
            //}
            //Console.WriteLine("The missing elements form 0 to 9 are : {0}",x);
           
            #endregion


        }




        static public int GetInterger(string message)
        {
            Console.WriteLine("******Getting Input from user********");
            Console.WriteLine(message + ":");
            int tempvalue;
            if (!int.TryParse(Console.ReadLine(), out tempvalue))
            {
                return GetInterger("Please enter the valid integer :");
            }
            return tempvalue;
        }

        static public int count_value(int[] ma, int x)
        {
            int count = 0;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] == x)
                {
                    count++;

                }
            }
            return count;
        }

        static public void print_array(int[] ma)
        {
            
            for (int i = 0; i < ma.Length; i++)
            {

                Console.Write(ma[i] +"\t");
            }
            Console.WriteLine();
         


        }


        static public bool q_1(int[] ma, int x )
        {
            bool x1 = false;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] == x)
                {
                    x1 = true;
                    
                }
               
            }
            return x1;
        }

        static public bool q_11(int[] ma, int x) //two pointer
        {
            bool x1 = false;
            for (int i = 0; i < ma.Length/2; i++)
            {
                for (int j = ma.Length / 2; j < ma.Length; j++)
                {
                    if (ma[i] == x || ma[j]== x)
                    {
                        x1 = true;

                    }
                }

            }
            return x1;
        }

        static public int q_2(int[] ma, int x)
        {
            int index_val = -1;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] == x)
                {
                    index_val = i;
                }
            }
            return index_val;
        }

        static public int q_22(int[] ma, int x)//two pointer
        {
            int x1 = -1;
            for (int i = 0; i < ma.Length / 2; i++)
            {
                for (int j = ma.Length/2; j < ma.Length; j++)
                {
                    if (ma[i] == x)
                    {
                        x1=i;
                    }
                     else if (ma[j] == x)
                    {
                        x1 = j;
                    }

                }
            }
            return x1;
        }

        static public bool q_3(int[] ma, int x)
        {
            bool x1 = false;
            int count = 0;
            if (q_1(ma, x) == false)
            {
                Console.WriteLine("The  target Value is not present in the array");
            }
            else if (q_1(ma, x))
            {
                for (int i = 0; i < ma.Length; i++)
                {
                    if (ma[i] == x)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    x1 = true;

                }

            }
            return x1;
        }

        static public bool q_33(int[] ma,int x,int start)
        {
            bool x1 = false;
            if (q_1(ma, x))
            {
                x1 = true;


            }
            return x1;
        }

        static public int q_4(int[] ma, int x)
        {
            int x1 = 0;
            int count = 0;
            if(q_1(ma,x)==false)
            {
                x1= -1;
            }
            else
            {
                for (int i = 0; i < ma.Length; i++)
                {
                    if (ma[i] == x)
                    {
                        count++;
                        if (count == 2)
                        {
                            x1 = i;

                        }
                       
                    }
                   
                }
            }
            return x1;
        }

        static public int q_6(int[] ma, int x)
        {
            int no_of_times = 0;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] == x)
                {
                    no_of_times++;
                }
            }
            return no_of_times;
        }

        static public string q_42(int[] ma, int x)
           {
            string ans = "";
            if (q_1(ma, x)==false)
            {
                ans = "The given x is not present in the array";
            }
            else
            {
                for (int i = 0; i < ma.Length; i++)
                {
                    if (ma[i] == x)
                    {
                        ans = ans + i + "\t";
                    }
                }
            }
            return ans;
        }

        static public int[] q_43(int[] ma, int k)
        {
            int no_of_time= q_6(ma, k);
           // Console.WriteLine(no_of_time);
           /// Console.WriteLine(ma.Length);
            int len = ma.Length - no_of_time;
            int[] ma_1 = new int[len];
            for (int j=0;j<ma_1.Length;j++)
            {
               
                 if (ma[j]!=k)
                {
                    ma_1[j]=ma[j];

                    
                }
            }
            return ma_1;
        }

        static public int[] q_44(int[] ma, int k, int loc)
        {
            int[] res = new int[ma.Length + 1];
            //Console.WriteLine(ma.Length);
            //Console.WriteLine(res.Length);
            int i = 0;
                for (int j = 0; j < res.Length; j++)
                {
                    if (j != loc)
                    {
                        res[j] = ma[i];
                        i++;
                    }
                    else if(j==loc)
                    {
                        res[j] = k;

                    }

                }
            
            return res;
            
        }

        static public int[] q_45(int[] ma, int loc)
        {
            int i = 0;
            int[] res = new int[ma.Length - 1];
            for (int j= 0; j< res.Length; j++)
            {
               
                 if (j< loc)
                {
                    res[j] = ma[i];
                    i++;

                }
                 else if (j>=loc)
                {
                    res[j] = ma[i+1];
                    i++;
                    
                   
                    
                }
                

            }
            return res;

        }

        static public int q_46_small(int[] ma)
        {
            int small=int.MaxValue;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] < small)
                {
                    small = ma[i];


                }
            }
            return small;

        }

        static public int q_46_2(int[] ma)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;
            for (int i = 0; i < ma.Length; i++)
            {
                for (int j = 0; j < ma.Length; j++)
                {
                    if (first>ma[i] && second>ma[j])
                    {
                        first = ma[i];
                        second = ma[j];
                    }


                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            return 0;

        }

        static public int q_47_small(int[] ma)
        {
            int count = 0;
            int small = int.MaxValue;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] < small)
                {
                    small = ma[i];
                    count++;


                }
            }
            Console.WriteLine(small);
            return count;

        }

        static public int q_48(int[] ma)
        {
            int small = int.MaxValue;
            int indx = -1;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] < small)
                {
                    small = ma[i];
                    indx = i;
                    
                }
                   
            }
            Console.WriteLine(small);
            return indx;
        }

        static public int q_49_large(int[] ma)
        {
            int large = int.MinValue;
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] > large)
                {
                    large=ma[i];
                }
            }
            return large;
        }

        static public int q_53_timeslarge(int[] ma)
        {
            int count = 0;

            int large = q_49_large(ma);
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] == large)
                {
                    count++;
                }
            }
            return count;
        }

        static public int q_54_timessmall(int[] ma)
        {
            int count = 0;

            int small = q_46_small(ma);
            for (int i = 0; i < ma.Length; i++)
            {
                if (ma[i] == small)
                {
                    count++;
                }
            }
            return count;
        }

        static public int q_56(int min_range, int max_range, int[] ma)
        {
            int count = 0;
            for (int i = 0; i < ma.Length; i++)
            {
                if (min_range<=ma[i] && max_range>=ma[i])
                {
                   // Console.WriteLine(ma[i]);
                    count++;
                }
               
            }
            return count;
        }

        static public int q_57(int[] ma,int j)
        {
            int c = 0;
            
                int a = ma[j];
                for (int i = 0; i < ma.Length; i++)
                {
                    if (ma[i] == a)
                    {
                        c++;

                    }
                }
              
            
            
            return c;
            
        }

        static public int q_58(int[] ma,int j)
        {
           
            int a = ma[j];
            int count = 0;
            for (int i = 0; i < ma.Length; i++)
            {
                if (a == ma[i])
                {
                    count++;
                }


            }
            return count;
        }

        static public int q_60(int[] ma,int j)
        {   
               int count = 0;
                for (int i = 0; i < ma.Length; i++)
                {
                    if (j==ma[i])
                    {
                        count++;
                    }
                }


                return count;
         
           
        }

        static public int q_40(int[] ma, int x, int k)
        {
            int res=-1;
            int count = 0;
            for (int i = 0; i < ma.Length; i++)
            {
               
                
                if (x == ma[i])
                {
                    count++;
                    if (count == k)
                    {
                        res = i;

                    }
                    
                }
            }
            return res;
        }

       
       


       




       
       
        
           











        }
    }

