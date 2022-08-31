using System;
using System.Linq;

namespace PalindromeExerciseTests
{
    public class WordSmith
    {

                         
        public bool IsAPalindrome(string palin1)
        {
            // reverse the word
            //var reversed = "";
            //var noSpaces = palin1.Replace(" ", "");

            //for (int i = palin1.Length -1; i >= 0; i--)
            //{
            //    reversed += palin1.ToLower()[i]; 
            //}

            //// compare the original with the reversed
            //if ( reversed == palin1.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false; 
            //}

            // return whether they are the same or not

            // Try Linq
            return palin1?.Replace(" ", "").ToLower().SequenceEqual(palin1?.Replace(" ", "").ToLower().Reverse()) ?? false;

        }









    }
}
