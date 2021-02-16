using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //var reverseWord = word.Reverse();
            //return word.ToLower().SequenceEqual(reverseWord);
            //return word.SequenceEqual(word.Reverse());
            //var reversed = word.Reverse().ToString();

            //if(reversed == word)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            ////reverse word 
            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            //compare the original with the reversed
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }

            ////return whether they are the same or not

        }
    }
}
