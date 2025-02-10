using UnityEngine;

namespace Assignment297
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            print($"Recursive method => 10! =  {FibonacciIterative(10)}, 30! = {FibonacciIterative(30)}");
            print($"Iterative method => 10! =  {FibonacciIterative(10)}, 30! = {FibonacciIterative(30)}");
        }

        //Write a recursive method that calculates the nth Fibonacci number.
        public float FibonacciRecursive(int n)
        {
            if (n < 0) return -1;
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        //Write an iterative method that calculates the nth Fibonacci number using a loop.
        public float FibonacciIterative(int n)
        {
            if(n < 0) return -1;
    
            float result = 1f;

            for(int i = 1; i <= n; i++)
            {
                result *= i; 
            }

            return result;
        }
    }
}
