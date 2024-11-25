using UnityEngine;

namespace Assignment10
{
    public class MultiplicationTable : MonoBehaviour
    {
        // Start is called before the first frame update 
        void Start()
        {
            //create a for loop to generate a multiplication table for the number 5, iterating from 1 to 10.
            for(int i = 1; i < 11; i++)
            {
                /*call the Multiply function with the current loop index (from 1 to 10) and the number 5.
                Log the result to the Unity Console in the format: "5 x 1 = 5", "5 x 2 =10", etc.*/
                Debug.Log("5 x " + i + " = " + Multiply(5,i));
            }
        }

        //Define a function called Multiply that takes two integers and returns an integer.
        int Multiply(int number1, int number2)
        {
            //The function should multiply them, and return the result.
            return number1 * number2;
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }
}