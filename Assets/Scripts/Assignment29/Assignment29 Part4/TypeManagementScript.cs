using System.Collections.Generic;
using UnityEngine;

namespace Assignment294
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            //Create a Cat object and upcast it (implicitly) to an Animal reference.
            Cat persianCat = new Cat();
            Animal cat = persianCat;

            //Call both MakeSound() and Move() on the upcasted reference.
            cat.MakeSound();
            cat.Move();

            //Downcast the Animal reference back to a Cat object using the as keyword.
            persianCat = cat as Cat;

            //Call both MakeSound() and Move() on the downcasted object.
            persianCat.MakeSound();
            persianCat.Move();

            //Create a List of ICanFight objects containing instances of both Cat and Warrior.
            Warrior warrior = new Warrior();
            List<ICanFight> fightingCreatures = new List<ICanFight>();
            fightingCreatures.Add(persianCat);
            fightingCreatures.Add(warrior);

            //Iterate through the list and call Attack() on each object.
            foreach (ICanFight creature in fightingCreatures)
            {
                creature.Attack();
            }

            foreach (ICanFight creature in fightingCreatures)
            {
                if (creature is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }
                else
                {
                    Debug.Log("The object is a Warrior.");
                }
            }
        }
    }

    public class Animal
    {
        //Add a virtual method MakeSound() that logs "Animal sound".
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        //Add a method Move() that logs "Animal moves.".
        public void Move()
        {
            Debug.Log("Animal moves.");
        }
    }

    public class Cat : Animal, ICanFight
    {
        //Override the MakeSound() method to log "Meow!".
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }

        //Add Move() method to log "Cat runs quickly.".
        public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }

        //Implement ICanFight in the Cat Class
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }

    //Create an Interface ICanFight
    public interface ICanFight
    {
        //Add a method Attack().
        public void Attack();
    }

    public class Warrior : ICanFight
    {
        //Add an Attack() method that logs 
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }
}

