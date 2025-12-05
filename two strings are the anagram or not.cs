using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "silent"; string str2 = "listen";
            char[] ch1 = str1.ToLower().ToCharArray(); char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1); Array.Sort(ch2); string val1 = new string(ch1); string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
    }
}