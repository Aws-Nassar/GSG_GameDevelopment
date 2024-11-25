using UnityEngine;

namespace Assignment14
{
    //Make an Enemy class that also inherits from the Character class.
    public class Enemy : Character
    {
        // Adding constructor to Enemy to correctly initialize base Character class
        public Enemy(string enemyName, int enemyHealth) : base(enemyName, enemyHealth)
        {
        }
        public void Attack(Character opponent, int amount)
        {
            opponent.Health -= amount;
        }
    }
}
