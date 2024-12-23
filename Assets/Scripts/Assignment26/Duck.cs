using UnityEngine;

namespace Assignment26
{
    //Create a Duck class that inherits from Creature and implements IRunnable and ISwimmable.
    public class Duck : Creature, IRunnable, ISwimmable
    {
        //Implement IRunnable.Run()
        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        //Implement ISwimmable.Swim()
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        //Overriade Creature.Speak()
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }
}
