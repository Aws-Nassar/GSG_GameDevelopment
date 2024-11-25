using UnityEngine;

namespace Assignment8
{
    public class sentenceGenerator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //array of these words:Cat, Dog, Car, Pizza, Hat, Fish, Tree, Monkey, Ball, Bird.
            string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};

            string sentence = "";
            int count = 1;
            int randomChoose;

            //Use a while loop to build a funny sentence with 7 words randomly chosen from the array.
            while (count <= 7)
            {
                randomChoose = Random.Range(0, words.Length);
                sentence +=  words[randomChoose] + " ";
                count++;
            }

            //Print the sentence to the console.
            Debug.Log(sentence);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}