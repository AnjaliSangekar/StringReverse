using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Reverse : ");
            Reverse("Hello");
            Console.WriteLine();
            Console.WriteLine("Palindrome string");
            Palindrome("madamhhh");
            Console.WriteLine();
            Console.WriteLine("Reverse order of string word");
            reverseOrderofWord("I like this program");
            Console.WriteLine();
            Console.WriteLine("Reverse string each word and order");
            ReverseEachWordAndOrder("welcome to home");
            Console.WriteLine();
            Console.WriteLine("Reverse each word");
            ReveserEachWord("welcome to pune");

        }

        public static void Reverse(string str)
        {
            char[] charArray = str.ToCharArray();

            for(int i=0, j = str.Length-1; i<j; i++, j--)
            {
                    charArray[i] = str[j];
                    charArray[j] = str[i];
                
            }


            string Reverse = new string(charArray);
            Console.WriteLine(str);
            Console.WriteLine(Reverse);
        }


        public static void Palindrome(string s)
        {
            bool flag = false;

            for(int i=0, j = s.Length-1; i<s.Length; i++, j--) // i<s.Length/2
            {
                if (s[i] != s[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag)
                // Console.WriteLine(s);
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }


        public static void reverseOrderofWord(string str)
        {
            string[] s = str.Split(' ');
            string ans = "";

            for(int i = s.Length-1; i >= 0; i--)
            {
                ans = ans + s[i] + " ";
            }

            Console.WriteLine(str);
            Console.WriteLine(ans.Substring(0, ans.Length-1));
        }


        public static void ReverseEachWordAndOrder(string s)
        {
            string newStr = string.Empty;

            for(int i = s.Length-1; i >= 0; i--)
            {
                newStr = newStr + s[i];
            }

            Console.WriteLine(s);
            Console.WriteLine(newStr);
        }


        public static void ReveserEachWord(string str)
        {
            Console.WriteLine(str);
            var spcArr = str.Split(' ');
            str = "";
            foreach (var w in spcArr)
            {
                char[] arr = w.ToCharArray();
                for (int i = arr.Length-1; i >= 0; i--)
{
                    str += arr[i];
                }

                str += " ";
            }

            
            Console.WriteLine(str.Trim());
        }
    
    }
}
