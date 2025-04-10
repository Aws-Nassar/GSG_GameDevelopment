using System;
using UnityEngine;
namespace Assignment352
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        //Inside the script, define a delegate named MathOperation that accepts an int parameter.
        public delegate void MathOperation(int number);
        MathOperation operation;

        //This method should double the input number and print the result to the Console.
        void DoubleNumber(int number) => Debug.Log(number * 2);

        //This method should square the input number and print the result to the Console.
        void SquareNumber(int number) => Debug.Log(Math.Pow(number, 2));

        //This method should cube the input number and print the result to the Console.
        void CubeNumber(int number) => Debug.Log(Math.Pow(number, 3));
        void Start()
        {
            //Use the += operator to add all three methods to the MathOperation delegate.
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;

            //Call the delegate with an input value (e.g., 5) to execute all three methods in sequence.
            operation(5);
        }
    }
}
