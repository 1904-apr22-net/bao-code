using System;
using System.Collections.Generic;

namespace Palindrome.Library
{
    public class palindrome
    {
        public palindrome()
        {

        }
        public bool isPalindrome(string str)
        {
            if (str.Length == 0)
            {
                return true;
            }

            str = str.ToLower();
            str = removeNonAlphabetChar(str);

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public string removeNonAlphabetChar(string str)
        {
            char[] charOfWord = str.ToCharArray();
            List<char> words = new List<char>();

            for (int i = 0; i < charOfWord.Length; i++)
            {
                if (char.IsLetter(charOfWord[i]))
                {
                    words.Add(charOfWord[i]);
                }
            }

            return words.ToString();
        }
    }
}
