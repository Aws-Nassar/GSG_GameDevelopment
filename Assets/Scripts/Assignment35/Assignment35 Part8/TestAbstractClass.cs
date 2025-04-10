using UnityEngine;
namespace Assignment358
{
    public class TestAbstractClass : MonoBehaviour
    {
        DerivedClassExample derivedClassExample;

        //implemented abstract method and the concrete method from the derived class. PerformAction(); PrintInfo();
        void Start()
        {
            derivedClassExample = new DerivedClassExample();
            derivedClassExample.PerformAction();
            derivedClassExample.PrintInfo();
        }
    }
}
