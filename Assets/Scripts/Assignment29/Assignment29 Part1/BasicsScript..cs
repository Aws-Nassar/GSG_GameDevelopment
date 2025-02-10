using UnityEngine;
namespace Assignment291
{
    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            //Declare three variables using var (an integer, a string, and a boolean).
            var intgerVar = 5;
            var stringVar = "Aws";
            var booleanVar = false;

            //Use the ternary operator ?: to check if the integer is even or odd.
            stringVar = (intgerVar % 2 == 0)? "even" : "odd"; 

            //Use string interpolation to create a message and log it using Debug.Log.
            Debug.Log($"The Number {intgerVar} is {stringVar}");

            //Log the current date, time, Day using System.DateTime.
            Debug.Log($"Today is {System.DateTime.Now.ToString("dddd, MMMM dd, yyyy - HH:mm:ss")}"); // stack overflow way to specify the format 
        }
    }
}


