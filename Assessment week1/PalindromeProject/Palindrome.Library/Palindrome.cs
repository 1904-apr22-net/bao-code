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
                if (str[i] != str[str.Length - (i+1)])
                {
                    return false;
                }
            }
            return true;
        }

        public string removeNonAlphabetChar(string str)
        {
            string word = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    word = word + str[i];
                }
            }
            return word;
        }
    }
}
