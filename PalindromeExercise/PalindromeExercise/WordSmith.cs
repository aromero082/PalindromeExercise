using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool  IsAPalindrome(string word)
        {
            //reverse the word racecar
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                reversed += word[i];
            }
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Palindrome(string word)
        {
            throw new NotImplementedException();
        }
    }
}
