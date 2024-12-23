using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            //Create a list that contains one Kangaroo instance and one Duck instance.
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();
            List<Creature> creatures = new List<Creature>{kangaroo, duck};

            //Create separate lists for each interface
            List<IRunnable> runnableCreatures = new List<IRunnable>();
            List<IJumpable> jumpableCreatures = new List<IJumpable>();
            List<ISwimmable> swimmableCreatures = new List<ISwimmable>();

            //Add the Kangaroo instance to both the IRunnable and IJumpable lists.
            runnableCreatures.Add(kangaroo);
            jumpableCreatures.Add(kangaroo);

            //Add the Duck instance to both the IRunnable and ISwimmable lists.
            runnableCreatures.Add(duck);
            swimmableCreatures.Add(duck);

            //For each creature (the Kangaroo and Duck), call Speak().
            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            
            //For each creature in IRunnable, call Run().
            foreach (IRunnable runnable in runnableCreatures)
            {
                runnable.Run();
            }

            //For each creature in IJumpable, call Jump().
            foreach (IJumpable jumpable in jumpableCreatures)
            {
                jumpable.Jump();
            }

            //For each creature in ISwimmable, call Swim().
            foreach (ISwimmable swimmable in swimmableCreatures)
            {
                swimmable.Swim();
            }
        }
    }
}
