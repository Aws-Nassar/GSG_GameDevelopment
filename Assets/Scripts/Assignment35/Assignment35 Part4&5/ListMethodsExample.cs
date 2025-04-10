using UnityEngine;
using System.Collections.Generic;
namespace Assignment354
{
    public class ListMethodsExample : MonoBehaviour
    {
        //Initialize a List<int> named numbers and populate it with several integer values.
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };

        //Initialize a List<int> named numbers2 and populate it with several integer values.
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filteredNumbers;
        void Start()
        {
            //Use the Sort method on the list and pass a lambda expression to compare two integers, 
            // x and y, in reverse order.
            //Use y.CompareTo(x) in the lambda expression to swap the default comparison order.
            numbers.Sort((int x, int y) => y.CompareTo(x));
            
            //Use string.Join(", ", numbers) to convert the sorted list into a single string with 
            // elements separated by commas.
            print(string.Join(", ", numbers));

            //Use the FindAll method to create a new list filteredNumbers containing only the elements 
            // that satisfy the condition to find all even numbers.
            filteredNumbers = numbers2.FindAll((int no) => no % 2 == 0);

            //Use string.Join(", ", filteredNumbers) to convert the filtered list into a single 
            // string and log it to the Console.
            print(string.Join(", ", filteredNumbers));
            
        }
    }
}
