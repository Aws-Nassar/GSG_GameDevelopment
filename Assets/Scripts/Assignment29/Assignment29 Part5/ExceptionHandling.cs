using System;
using UnityEngine;

namespace Assignment295
{
    public class ExceptionHandling : MonoBehaviour
    {
        void Start()
        {
            //Declare two int variables
            int playerScore = 100;
            int diviser = 0; //(intentionally set to 0 to simulate division by zero).
            
            Debug.Log("Attempting to calculate score multiplier...");

            try
            {
                int totalScore = playerScore / diviser;
            }
            
            catch (DivideByZeroException e)
            {
                Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            }
            
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }
    }
}
