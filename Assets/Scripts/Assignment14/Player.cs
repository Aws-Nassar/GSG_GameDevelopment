using UnityEngine;

namespace Assignment14
{
    //Make a Player class that inherits from the Character class.
    public class Player : Character
    {
        // Adding constructor to Player to correctly initialize base Character class
        public Player(string playerName, int playerHealth) : base(playerName, playerHealth)
        {
        }

        //Add a Heal() method that increases (or "heals") the player’s Health by a certain amount.
        public void Heal(int amount)
        {
            Health += amount;
        }
    }
}
