using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringQA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            string s = Getstring("Enter the string");
           //Console.WriteLine("Enter the charcter");
           //char a = Convert.ToChar(Console.ReadLine());
           //bool ans1 = iscons(a) ;
         
           //Console.WriteLine(ans1);
           
            #endregion
            #region 1
           // int ans = position_char_sb(a,s);
           // Console.WriteLine(ans);
            #endregion

            #region 2

            //int k = GetInterger("Enter the position where you want to search");
            //int ans = position_afterk(a,s,k);
            //Console.WriteLine(ans);
            #endregion

            #region 3
            //int ans = count_char(a, s);
           // Console.WriteLine(ans);
            #endregion

            #region 4
         //   int ans = unique_count(s);
          //  Console.WriteLine(ans);


#endregion

            #region 5
         //   string ans = print_repeated_char(s);
         //   Console.WriteLine(ans);
            #endregion

            #region 6
          //  int k = GetInterger("ENter the times ");
           // string ans = print_ktimes_repeated(s, k);
          //  Console.WriteLine(ans);
            #endregion

            #region 7
           // string ans = count_VowLetterDigit(s);
           // string ans = count_all(s);
          //  Console.WriteLine(ans);
            #endregion

            #region 8
          ////  string ans = vow_upper(s);
          //  Console.WriteLine(ans);
            #endregion
             
            #region 9
          // string ans = remove_vow(s);
          // Console.WriteLine(ans);

            #endregion

            #region 10
           // string ans = remove_con(s);
           // Console.WriteLine(ans);
            #endregion

            #region 11
          //  string ans = remove_unique(s);
          ///  Console.WriteLine(ans);
            #endregion

            #region 13
     //       string ans = count_upplow(s);
      //      Console.WriteLine(ans);
            #endregion

            #region 15
          // bool ans=  onlydigit(s);
          // Console.WriteLine(ans);
            #endregion

            #region 16
          //  string ans = remove_nonnumerics(s);
          //  Console.WriteLine(ans);
            #endregion

            #region 17
           // string ans = remove_splchar_c(s);
           // Console.WriteLine(ans);
            #endregion

            #region 18
        //    string ans = remove_num_s(s);
         //   Console.WriteLine(ans);
            #endregion

            #region 19
           // string ans = remove_spaces(s);
           // Console.WriteLine(ans);
            #endregion

            #region 21 22 23
            //string a = Getstring("ENter the patter to be checked");
            ////int k = GetInterger("ENter the position");
            //bool result = ispatternpresent(s, a);
            //Console.WriteLine(result);
            #endregion

            #region 24
           // string ans = string_last_2(s);

           // Console.WriteLine(ans);
            #endregion


        }
        public static int position_char(char a,string s)
        {
            int position = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == a)
                {
                    position = i;
                    break;
                }
               
               
            }
            return position;
        }
        public static int position_char_s(char a, string s)
        {
            int pos = -1;
         
            if (s.Contains(a))
            {
                pos = s.IndexOf(a);
            }
            else if (!s.Contains(a))
            {
                pos = -1;
            }
            return pos;
           


        }

        public static int position_afterk_sb(char a, string s,int k)
        {
            int position = -1;
            StringBuilder s1 = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Contains(a) && s.IndexOf(a) >= k)
                {
                    position = s.IndexOf(a);

                }
            }
                     return position;
            

        }
        public static int position_afterk(char a, string s, int k)
        {
            int position = -1;
            for (int i = k; i < s.Length; i++)
            {
                if (s[i] == a)
                {
                    position = i;
                    break;
  
                }
            }
            return position;
        }

        public static int count_char(char a, string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == a)
                {
                    count++;
                }
            }
            return count;
        }
        public static int count_char_s(char a, string s)
        {
            int pos = -1;
            if (s.Contains(a))
            {
                pos = s.IndexOf(a);

            }
            return pos;
        }//

        public static int unique_count(string s)
        {
            int uni_count = 0;
            for (int i = 0; i < s.Length; i++)
            {
               if(count_char(s[i],s)==1)
                {
                    uni_count++;
                }
                
            }
            return uni_count;
        }

        public static string print_repeated_char(string s)
        {
            string result = "";
            
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                    }
                    
                }
                if (count==1)
                {
                    result = result + s[i];
                    
                }
            }
            return result;

        }

        public static string print_ktimes_repeated(string s,int k)
        {
            string result="";
            for (int i = 0; i < s.Length; i++)
            {
                

                int count = 0;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                    }
                }
                if (count >= k)
                {
                    result += s[i];
                }
            }
            return result;
        }

        public static string count_VowLetterDigit(string s)
        {
            string res = "";
        
            int vow_count = 0;
            List<char> ls = new List<char> { 'a','e','i','o','u'};
            
     
            
            for (int i = 0; i < s.Length; i++)
            {
              

                if(ls.Contains(s[i]))
                {
                    vow_count++;
                }
                                              
            }
            
            Console.WriteLine("vowel count:{0} ",vow_count);
            return res;
            

           
            

        }
        public static string count_all(string s)
        {
            int digit=0;
            int letter=0;
            int vow = 0;
            string res = "";
            List<char> ls = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < s.Length; i++)
            {
                if(char.IsDigit(s[i]))
                {
                    digit++;
                }
                if(char.IsLetter(s[i])&& !ls.Contains(s[i]))
                {
                    letter++;
                }
                if (ls.Contains(s[i]))
                {
                    vow++;
                    
                }
            }
            Console.WriteLine("The diigit count :{0}",digit);
            Console.WriteLine("The letter count :{0}",letter);
            Console.WriteLine("The vow count:{0}",vow);
            return res;

        }

        public static string vow_upper(string a)
        {
            string s = "";

            List<char> ls = new List<char> {'a','e','i','o','u'};
            for (int i = 0; i < a.Length; i++)
            {
                if (ls.Contains(a[i]))
                {
                    s = s + char.ToUpper(a[i]);
                }
                else
                {
                    s = s + a[i];
                }

                
            }
            return s;
        }

        public static string remove_vow(string s)
        {
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(isvow(s[i])==false)
                {
                    a = a + s[i];
                }
            }
            return a;
        }

        public static string remove_con(string s)
        {
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (iscons(s[i]) == false)
                {
                    a = a + s[i];
                }
            }
            return a;
        }

        public static string remove_unique(string s)
        {
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;

                    }
                   
                }
                if (count == 0)
                {
                    a = a + '#';
                }
                else
                {
                    a = a + s[i];
                }
              
            }
            return a;
        }///

        public static string count_upplow(string s)
        {
            string res = "";
            int upp = 0;
            int low = 0;
            int num = 0;
            int sym = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    upp++;
                }
                else  if (char.IsLower(s[i]))
                {
                    low++;
                }
                else  if (char.IsDigit(s[i]))
                {
                    num++;
                }
                else  if (char.IsSymbol(s[i]))
                {
                    sym++;
                }

            }
            Console.WriteLine("Symbol count:{0}",sym);
            Console.WriteLine("Upper :{0}",upp);
            Console.WriteLine("lower:{0}",low);
            Console.WriteLine("number:{0}",num);
            return res;
        }

        public static bool onlydigit(string s)
        {
            bool a = true;
           
            for (int i = 0; i < s.Length; i++)
            {

                if (!char.IsDigit(s[i]))
                {
                    a = false;
                    break;

                }
                
               
            }
            return a;
        }

        public static string remove_nonnumerics(string s)
        {
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    a += s[i];
                }
            }
            return a;
        }
//        public static string remove_nonnumerics_sb(string s)
        //{
          
        //    StringBuilder bul = new StringBuilder(s);
        //    for (int i = 0; i < bul.Length; i++)
        //    {
        //        if (!char.IsDigit(bul[i]))
        //        {
                    
        //        }
        //    }
        //}

        public static string remove_splchar(string s)
        {
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(!(s[i]=='!'||s[i]=='@'||s[i]=='$'||s[i]=='%'||s[i]=='^'||s[i]=='&'||s[i]=='*'||s[i]=='('||s[i]==')'||s[i]=='+'
                   || s[i]=='='||s[i]=='_'||s[i]=='#'))
                {
                    a += s[i];

                }
            }
            return a;
        }
        public static string remove_splchar_c(string s)
        {
            string a = "";
            int i = 0;
            int count=s.Length;
            while (count!=0)
            {  
                if (!(char.IsSymbol(s[i])))
                {
                    a += s[i];
         
                }
                i++;
                count--;
            }
            return a;
        }

        public static string remove_number(string s)
        {
            string ans = "";
            int count = s.Length;
            int i = 0;
            while (count != 0)
            {
                if (!(char.IsDigit(s[i])))
                {
                    ans += s[i];

                }
                count--;
                i++;
            }
            return ans;

        }
        public static string remove_num_s(string s)
        {
            string a = "";
            if (!(s.Contains('0')))
            {
                return s;
            }
            else
            {
                a = s.Remove('1');
                return a;
            }
            
        }

        public static string remove_spaces(string s)
        {
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    

                }
                else
                {
                    a += s[i];
                }
            }
            return a;
        }///

        public static bool ispatternpresent(string parent, string a)
        {
            char a1 = a[0];
            bool ans = false;
            for (int i = 0; i < parent.Length; i++)
            {
                if (parent[i] == a1)
                {
                    for (int j = 1; j < a.Length; j++)
                    {
                        if (parent[i + 1] == a[j])
                        {
                            ans = true;
                            i++;

                        }

                    }

                }
              
               
            }
            return ans;
           
          


        }

        public static bool pattern_index(string parent, string a)
        {
            char a1 = a[0];
            bool ans = false;
            for (int i = 0; i < parent.Length; i++)
            {
                if (parent[i] == a1)
                {
                    for (int j = 1; j < a.Length; j++)
                    {
                        if (parent[i + 1] == a[j])
                        {
                            Console.WriteLine(i);
                            ans = true;

                        }
                        else
                        {
                            ans = false;
                        }

                    }

                }
            }
            return ans;




        }

        public static bool pattern_index_k(string parent, string a,int k)
        {
            char a1 = a[0];
            bool ans = false;
            for (int i = k; i < parent.Length; i++)
            {
                if (parent[i] == a1)
                {
                    for (int j = 1; j < a.Length; j++)
                    {
                        if (parent[i + 1] == a[j])
                        {
                            Console.WriteLine(i);
                            ans = true;

                        }
                        else
                        {
                            ans = false;
                        }

                    }

                }
            }
            return ans;




        }//

        public static string string_by_2(string s)
        {
            string ans = "";
            
            if (s.Length < 2)
            {
                return " ";
            }
            else
            {
              
               for (int i = 0; i <2; i++)
                {
                    ans += s[i];
                    Console.WriteLine(ans);
                }
                
                return ans;
                
            }
            
        }
        public static string string_last_2(string s)
        {
            string ans = "";
            int count = s.Length-2;
            int real_count = s.Length;
            while (s.Length != count)
            {
                ans = ans + s[real_count];
                real_count--;
                

            }
            return ans;
            
          
        }
























        public static bool isvow(char a)
        {
            bool ans = false;
            List<char> ls = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            if (ls.Contains(a))
            {
                ans = true;
            }
            else if (!ls.Contains(a))
            {
                ans=false;
            }
            return ans;
        }

        public static bool iscons(char a)
        {
            bool ans = false;
            if (char.IsLetter(a) && isvow(a) == false)
            {
                ans = true;
            }
            return ans;
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
        static public double GetDouble(string message)
        {
            Console.WriteLine("******Getting Input from user********");
            Console.WriteLine(message + ":");
            double tempvalue;
            if (!double.TryParse(Console.ReadLine(), out tempvalue))
            {
                return GetInterger("Please enter the valid Double :");
            }
            return tempvalue;
        }
        static public string Getstring(string message)
        {
            Console.WriteLine("*********GettingInput*********");
            Console.WriteLine();
            Console.WriteLine(message + ",");
            string tempstring = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tempstring))
            {
                tempstring = Getstring("Please enter valid text");

            }
            return tempstring;


        }

    }
}
