using System;
using System.Collections.Generic;
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

            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                             +"@"
                             +@"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

            MatchEvaluator evaluator = new MatchEvaluator(WordReplacement);

            
            string newText = Regex.Replace(text, pattern, evaluator, RegexOptions.IgnorePatternWhitespace);
            return newText; 
        }

        private static string WordReplacement(Match match)
        {
            return "Secret Mail";
        }

        private static List<string> ListOfWordsGenerator(String word)
        {
            List<string> allWords = new List<string>();

            foreach (var wordWithReplaceing in DeletingALetter(word))
            {
                allWords.Add(word);
            }

            foreach (var wordWithReplaceing in InsertingALetter(word))
            {
                allWords.Add(word);
            }

            foreach (var wordWithReplaceing in ReplacingALetter(word))
            {
                allWords.Add(word);
            }
            
            foreach (var wordWithSwapping in SwappingAdjacentLetters(word))
            {
                allWords.Add(word);
            }
            return allWords;
        }

        private static List<string> SwappingAdjacentLetters(string word)
        {
            List<string> allWordsWithSwap = new List<string>();

            for (int i = 1; i < word.Length; i++)
            {
                char[] wordInChars = word.ToCharArray();
                var temp = wordInChars[i];
                wordInChars[i - 1] = wordInChars[i];
                wordInChars[i] = temp;
                string newWord = wordInChars.ToString();

                allWordsWithSwap.Add(newWord);
            }
            return allWordsWithSwap;
        }

        private static List<string> ReplacingALetter(string word)
        {
            List<string> allWordsWithReplacing = new List<string>();

            foreach (var letter in word)
            {
                char[] wordInChars = word.ToCharArray();

                // Must be something where I find the unicode value to be able to loop over the first 28 or so number and convert back to alfabet and replace each word. Adding all to the list.
            }

            return allWordsWithReplacing;
        }

        private static List<string> InsertingALetter(string word)
        {
            List<string> allWordsWithInserting = new List<string>();

            foreach (var letter in word)
            {
                char[] wordInChars = word.ToCharArray();

                // Must be something where I have the unicode value again and insert one by one on before each letter and also one in the end. 
            }

            return allWordsWithInserting;

        }

        private static List<string> DeletingALetter(string word)
        {
            List<string> allWordsWithDeleting = new List<string>();

            foreach (var letter in word)
            {
                char[] wordInChars = word.ToCharArray();

                // only delete first letter - new loop to do the same for all?
                for (int i = 1; i < wordInChars.Length; i++)
                {
                    wordInChars[i - 1] = wordInChars[i];
                }
                string newWord = wordInChars.ToString();

                allWordsWithDeleting.Add(newWord);
            }

            return allWordsWithDeleting;
        }
    }
}
