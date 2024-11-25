using UnityEngine;

namespace Assignment14
{
    //create another script GameManager (which inherits from MonoBehavior)
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //Create a Player and an Enemy character.
            Player mario = new Player("Mario", 70);
            Enemy wario = new Enemy("Wario", 100);

            //Print their Name and Health in the Unity Console.
            Debug.Log("Player Name: " + mario.Name + " \t Player Health: " + mario.Health);
            Debug.Log("Enemy Name: " + wario.Name + " \t Enemy Health: " + wario.Health);

            //Test the Heal() method on the player to increase their health (and print them).
            mario.Heal(10);
            Debug.Log(mario.Name + " Health: " + mario.Health);

            //Test the Attack() method on the enemy to reduce the player’s health (and print them).
            wario.Attack(mario,20);
            Debug.Log(mario.Name + " Health: " + mario.Health);
        }
    }
}
