using UnityEngine;

//In the same namespace
namespace Assignment18
{
    //Create a child classes Soldier that inherit from Character.
    public class Soldier : Character
    {
        //To call the default character constructor for the soldier
        public Soldier() : base()
        {
        }

        //A parameterized constructor to initialize name, Health, and position by calling the base constructor.
        public Soldier(string soliderName, int soliderHealth, Position soldierPosition) : base(soliderName, soliderHealth, soldierPosition)
        {
        }

        //Override the DisplayInfo() method in both child classes
        public override void DisplayInfo()
        {
            //Add Debug.Log("Soldier") for Soldier at the start of the method.
            Debug.Log("Soldier");

            //Call the base DisplayInfo() method using base.DisplayInfo() to display information from Character.
            base.DisplayInfo();
        }
    }
}
