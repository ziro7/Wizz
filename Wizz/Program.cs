using System;
using System.Text.RegularExpressions;

namespace Wizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("test"));
            Console.WriteLine(IsPalindrome("abba"));

            // FooBar();

            Console.WriteLine(MailReplacements("Christian has the email address christian + 123@gmail.com. Christian's friend, John Cave-Brown, has the email"));

            Console.ReadLine();




        }

        private static bool IsPalindrome(String text)
        {
            char[] content = text.ToCharArray();
            int length = content.Length;

            for (int i = 0; i < length/2; i++)
            {
                if(content[i] != content[length - i - 1]) { return false; }
            }
            return true;
        }

        private static void FooBar()
        {
            for (int i = 0; i < 101; i++)
            {
                if(i%3 == 0 && i % 5 == 0)
                { Console.WriteLine("FooBar");}
                else if (i % 3 == 0)
                { Console.WriteLine("Foo");}
                else if(i % 5 == 0)
                { Console.WriteLine("Bar");}
                else
                {Console.WriteLine(i);}
            }
        }

        private static string MailReplacements (String text)
        {
            string newText = Regex.Replace(text, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                                +"@"
                                                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$","SECRET MAIL");
            return newText; 
        }
    }
}
