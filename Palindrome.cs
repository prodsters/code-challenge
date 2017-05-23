//Ogbonna Vitalis(sage94)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public string MaxPalindrome(string input)
        {
            int rightIndex = 0, leftIndex = 0;
            List<string> paliList = new List<string>();
            string currentPalindrome = string.Empty;
            string longestPalindrome = string.Empty;
            for (int currentIndex = 1; currentIndex < input.Length - 1; currentIndex++)
            {
                leftIndex = currentIndex - 1;
                rightIndex = currentIndex + 1;
                while (leftIndex >= 0 && rightIndex < input.Length)
                {
                    if (input[leftIndex] != input[rightIndex])
                    {
                        break;
                    }
                    currentPalindrome = input.Substring(leftIndex, rightIndex - leftIndex + 1);
                    paliList.Add(currentPalindrome);
                    leftIndex--;
                    rightIndex++;
                }
            }
            var x = (from c in paliList select c).OrderByDescending(w => w.Length).First();
            return x;
        }
        static void Main(string[] args)
        {
            Program CallingMethod = new Program();

            Console.WriteLine("Give me a string, I will give you the Palindrome\a:");
            string giving = Console.ReadLine();
            string ans =CallingMethod.MaxPalindrome(giving);
            Console.WriteLine(ans);
            Console.ReadKey();



        }

      







    }

       


    
}
