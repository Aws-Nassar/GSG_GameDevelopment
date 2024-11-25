using UnityEngine;

namespace Assignment8
{
    public class numberGenerator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int randomNumber; 

            //while loop
            while(true)
            {
                //generates random numbers (from 1 to 20)
                randomNumber = Random.Range(1,21);

                //If the number is 5, use continue to skip printing it.
                if(randomNumber == 5)
                {
                    continue;
                } 

                //Print each number.
                Debug.Log("=> " + randomNumber);

                //If the number is 15, use break to exit the loop.
                if(randomNumber == 15)
                {
                    break;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}