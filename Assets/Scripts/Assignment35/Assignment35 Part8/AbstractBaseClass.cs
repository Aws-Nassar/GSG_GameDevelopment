using UnityEngine;
namespace Assignment358
{
    //Define an abstract class with one abstract method void PerformAction() and one concrete
    // void PrintInfo() method.
    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();
        public void PrintInfo()
        {
            Debug.Log("This is a concrete method in the abstract base class.");
        }
    }
}