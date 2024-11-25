using UnityEngine;

namespace Assignment13
{
    //Create a C# script named Player without “: MonoBehaviour” and remove the Start() and Update() methods.
    public class Player
    {
        //Define the following public fields: a. playerName (string) b. health (int)
        public string playerName;
        public int health;

        //Add a static field playerCount to keep track of the number of Player objects.
        static public int playerCount = 0; //The static variable that counts the number of created objects will work more effectively when associated with the constructor rather than a regular initialize function.

        //Implement a method InitializePlayer(string name, int initialHealth) to set the playerName and health.
        public void InitializePlayer(string name, int initialHealth)
        {
            playerName = name;
            health = initialHealth;

            //Increment playerCount within the InitializePlayer() method.
            playerCount++;
        }    

        //Add a method Heal(int amount) to increase health by a specified amount and print the update using Debug.Log().
        public void Heal(int amount)
        {
            health += amount;
            
            //Check if the health go above 100 or under zero
            if(health > 100)
            {
                health = 100;
            }
            else if(health < 0)
            {
                health = 0;
            }

            Debug.Log(playerName + " health: " + health);
        }
        
        //Overload the Heal() method to accept a bool fullRestore parameter to fully restore health when set to true.
        public void Heal(bool fullRestore)
        {
            if(fullRestore == true)
            {
                health = 100;
                Debug.Log(playerName + " health restored");
            }
        }

        //Create a static method ShowPlayerCount() to print playerCount using Debug.Log().
        static public void ShowPlayerCount()
        {
            Debug.Log("Players count: " + playerCount);
        }
    }
}
