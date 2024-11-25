using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem.Composites;

//Define a namespace named Assignment18 to contain all classes and structs for this assignment.
namespace Assignment18
{
    //Define a Struct Position
    public struct Position
    {
        //Add three public fields: float X, float Y, and float Z.
        public float x, y, z;

        //Implement a constructor to initialize these fields.
        public Position(float one, float two, float three)
        {
            this.x = one;
            this.y = two;
            this.z = three;
        }

        //Add a printPosition() method to output X, Y, and Z values using Debug.Log().
        public void printPosition()
        {
            Debug.Log("Your position coordinates => x: " + x + " | y: " + y + " | z: " + z);
        }
    }
}
