using UnityEngine;
namespace Assignment358
{
    //Inherit from the AbstractBaseClass.
    public class DerivedClassExample : AbstractBaseClass
    {
        //Implement the abstract method in the derived class.Use the override keyword to implement the abstract method.
        public override void PerformAction()
        {
            Debug.Log("PerformAction is implemented in the derived class.");
        }
    }
}
