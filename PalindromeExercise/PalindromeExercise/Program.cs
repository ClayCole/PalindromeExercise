using System;
using PalindromeExerciseTests;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new WordSmith();

            Console.WriteLine(tester.IsAPalindrome("racecar"));
        }
    }
}
