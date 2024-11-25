using UnityEngine;

namespace Assignment181
{
    //Create a class GameUtils
    public class GameUtils
    {
        //Add a static method DescribeItem<T>(T something) that returns a description of something as a string. Simply add the string "This item is " before the item’s value.
        public static string DescribeItem<T>(T something)
        {
            return "This item is a " + something;
        }
    }
}
