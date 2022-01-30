using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            int len = str.Length;
            char ch = str[12];
            Console.WriteLine("The character at the 12th index is: " + ch);
            Console.WriteLine("Do the string contain the word 'is'?");
            Console.WriteLine(str.Contains("is"));
            Console.WriteLine("New String is: " + str.Insert(len," and killed it"));
            Console.WriteLine("Does the string ends with the word 'dogs'?");
            Console.WriteLine(str.EndsWith("dogs"));
            string str1 = "The quick brown Fox jumps over the lazy Dog";
            Console.WriteLine("Is the string equal to '"+str1+"'?");
            Console.WriteLine(str.Equals(str1));
            string str2 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            Console.WriteLine("Is the string equal to '" + str2 + "'?");
            Console.WriteLine(str.Equals(str2));
            Console.WriteLine("The length of the string is: "+len);
            Console.WriteLine("Does the string matches to '" + str1 + "'?");
            Console.WriteLine(string.Compare(str,str1));
            Console.WriteLine("After replacing the word 'The' with the word 'A' the new string is: " + str.Replace("The", "A"));
            string[] s1 = str.Split(' ');
            int i, j;
            string s2="", s3="";
            for(i=0;i<s1.Length;i++)
            {
                if (s1[i] == "fox")
                {
                    j = i;
                    break;
                }  
            }
            j = i;
            for(i=0;i<=j;i++)
            {
                s2 = String.Concat(s2, " ", s1[i]);
            }
            for (i = j+1; i <s1.Length; i++)
            {
                s3 = String.Concat(s3, " ", s1[i]);
            }
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            foreach (string s in s1)
            {
                if (s == "fox" || s == "dog")
                    Console.WriteLine(s);
            }
            Console.WriteLine("The string in complete lower case is:");
            Console.WriteLine(str.ToLower());
            Console.WriteLine("The string in complete upper case is:");
            Console.WriteLine(str.ToUpper());
            Console.WriteLine("The index of the character 'a' is: " + str.IndexOf('a'));
            Console.WriteLine("The last index of the character 'e' is: " + str.LastIndexOf('e'));
            Console.WriteLine("Enter the home directory of Tomcat Server:");
            string path = Console.ReadLine();
            string path1 = @"WebApps\MyApps\Images";
            string path2 = path + path1;
            Console.WriteLine("The final path is: " + path2);
            Console.ReadKey();
        }
    }
}
