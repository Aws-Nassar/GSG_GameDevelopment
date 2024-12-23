using UnityEngine;

namespace Assignment26
{
    //Create a Kangaroo class that inherits from Creature and implements IRunnable and IJumpable.
    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        //Implement IRunnable.Run()
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }

        //Implement IJumpable.Jump()
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }

        //Overriade Creature.Speak()
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }
    }
}
