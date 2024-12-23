using UnityEngine;

namespace Assignment26
{
    //IRunnable interface
    public interface IRunnable
    {
        //With a void Run() method.
        public void Run();
    }

    //IJumpable interface
    public interface IJumpable
    {
        //With a void Jump() method.
        public void Jump();
    }

    //ISwimmable interface
    public interface ISwimmable
    {
        //With a void Swim() method.
        public void Swim();
    }
}
