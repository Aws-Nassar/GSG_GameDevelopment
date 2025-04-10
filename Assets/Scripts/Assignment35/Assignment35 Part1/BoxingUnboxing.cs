using UnityEngine;
namespace Assignment351
{
    public class BoxingUnboxing : MonoBehaviour
    {
        //Declare an int variable (e.g., int health = 100;).
        int health = 100;
        void Start()
        {
            //Box this value into an object.
            object health2 = health;

            //Unbox the value back to an int and modify it.
            int health3 = (int)health2;
            health3 = 4;
            
            //Use Debug.Log to print results:
            Debug.Log(health);
            Debug.Log(health2);
            Debug.Log(health3);
        }
    }
}
