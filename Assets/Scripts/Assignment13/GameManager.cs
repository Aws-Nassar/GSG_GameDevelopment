using UnityEngine;

namespace Assignment13
{
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //Instantiate two Player objects.
            Player mario = new Player();
            Player wario = new Player();

            //Call InitializePlayer() to set playerName and health for each Player object.
            mario.InitializePlayer("Mario", 20);
            wario.InitializePlayer("Wario", 30);
            
            //Use both versions of the Heal() method to demonstrate method overloading.
            mario.Heal(true);
            wario.Heal(20);

            //Call ShowPlayerCount() to display the total number of Player objects.
            Player.ShowPlayerCount();
        }
    }
}
