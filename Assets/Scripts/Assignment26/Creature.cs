using UnityEngine;

//Placed inside the Assignment26 namespace.
namespace Assignment26
{
    //Base Class: Create a class called Creature with
    public class Creature
    {
        //Virtual method Speak().
        public virtual void Speak()
        {
            //Use Debug.Log() to display a generic message
            Debug.Log("A creature makes a sound.");
        }
    }
}
