using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class PalindromeClass
    {
        public bool IsPalindrome(string str)
        {
            if (str == null)
            {
                return false;
            }

            str = str.ToLower();
            str = RemoveNonAlphabetChar(str);

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - (i + 1)])
                {
                    return false;
                }
            }
            return true;
        }

        public string RemoveNonAlphabetChar(string str)
        {
            string word = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    word += str[i];
                }
            }
            return word;
        }
    }
}
