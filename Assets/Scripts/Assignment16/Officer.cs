using UnityEngine;

//In the same namespace
namespace Assignment18
{
    //Create a child classes Officer that inherit from Character.
    public class Officer : Character
    {
        //A parameterized constructor to initialize name, Health, and position by calling the base constructor.
        public Officer(string officerName, int officerHealth, Position officerPosition) : base(officerName, officerHealth, officerPosition)
        {

        }

        //Override the DisplayInfo() method in both child classes
        public override void DisplayInfo()
        {
            //Add Debug.Log("Officer") for Officer at the start of the method.
            Debug.Log("Officer");

            //Call the base DisplayInfo() method using base.DisplayInfo() to display information from Character.
            base.DisplayInfo();
        }
    }
}
