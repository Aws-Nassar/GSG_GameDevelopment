using UnityEngine;

namespace Assignment293
{
    //Create a static class called Utilities
    public static class Utilities
    {
        //Adds a static method that calculates and returns the sum of an array of numbers.
        public static int Add(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }

        //Write an extension method called RepeatString that repeats a string a specific number of times.
        public static string RepeatString(this string text, int number)
        {
            if (number > 0)
            {
                string result = "";
                for (int i = 0; i < number; i++)
                {
                    result += text;
                }
                return result;
            }
            return "";
        }
    }
}