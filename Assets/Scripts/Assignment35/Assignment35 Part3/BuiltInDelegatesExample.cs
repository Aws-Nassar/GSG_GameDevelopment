using System;
using UnityEngine;
namespace Assignment353
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        public delegate void Action();

        //Declare a Func<int, int> delegate.
        Func<int, int> square;

        //Declare a Predicate<int> delegate.
        Predicate<int> isEven;
        void Start()
        {
            //Declare an Action delegate.
            Action logMessage;
            
            //Assign it to a lambda expression that logs a string to the Console.
            logMessage = () => Debug.Log("Hello from Action delegate!");
            
            //Invoke the delegate to see the output.
            logMessage();
            
            //Assign it to a lambda expression that calculates the square of a number.
            square = (int no) => (int)(Math.Pow(no, 2));
            
            //Call the delegate with an input value 5 and log the result.
            Debug.Log($"Square: {square(5)}");

            //Assign it to a lambda expression that checks if the number is even.
            isEven = (int no) => no % 2 == 0;
            
            //Call the delegate with an input value 4 and log the result.
            Debug.Log($"Is 4 even? {isEven(4)}");
        }
    }
}
