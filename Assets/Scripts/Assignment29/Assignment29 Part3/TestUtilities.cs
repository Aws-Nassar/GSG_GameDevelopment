using UnityEngine;

namespace Assignment293
{
    public class TestUtilities : MonoBehaviour
    {
        void Start()
        {
            //Uses the Utilities.Add method to log the sum of numbers.
            Debug.Log($"The sum of the numbers (1, 2, 3, 4, 5, 6, 7, 8, 9) is: {Utilities.Add(1, 2, 3, 4, 5, 6, 7, 8, 9)}");

            //Uses the RepeatString extension method
            Debug.Log("run! ".RepeatString(3)); 
        }
    }
}

