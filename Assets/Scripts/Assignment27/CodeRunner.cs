using UnityEngine;

namespace Assignment27
{
    public class CodeRunner : MonoBehaviour
    {
        //Declare two integer variables and assign them initial values.
        int numberOne = 5, numberTwo = 15;

        void ModifyPassByValue(int number)
        {
            number += 10;
        }

        void ModifyPassByReference(ref int number)
        {
            number += 10;
        }

        void ModifyUsingOutKeyword(out int number)
        {
            number = 10;
        }

        void Start()
        {
            Debug.Log($"Numbers initial value: number one-> {numberOne} \t number two-> {numberTwo}");

            //Call by Value Demonstration
            ModifyPassByValue(numberOne);
            Debug.Log($"Call by Value, Number one value still the same -> {numberOne}");

            //Call by Reference Demonstration
            ModifyPassByReference(ref numberTwo);
            Debug.Log($"Call by Reference, Number two value changed -> {numberTwo}");

            //Using the out Keyword
            int numberThree;
            ModifyUsingOutKeyword(out numberThree);
            Debug.Log($"Using the out Keyword, Number three assigned a value -> {numberThree}");
        }
    }
}
