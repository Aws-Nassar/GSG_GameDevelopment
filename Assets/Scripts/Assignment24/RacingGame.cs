using UnityEngine;

namespace Assignment24
{

//Create a new C# script named RacingGame that inherits from MonoBehaviour.
    public class RacingGame : MonoBehaviour
    {
        //Declare a public RaceState variable called raceState.
        public RaceState raceState;

        //Write a method called SimulateRace() that handles the race logic using a switch statement. Add a default case to handle undefined states.
        void SimulateRace()
        {
            switch (raceState)
            {
                //Start, Accelerate, Turn, Crash, Finish
                case RaceState.Start:
                    Debug.Log("The race is about to begin. Get ready!");
                    break;

                case RaceState.Accelerate:
                    Debug.Log("You press the gas pedal. The car speeds up!");
                    break;

                case RaceState.Turn:
                    Debug.Log("You approach a sharp turn. Be careful not to crash!");
                    break;

                case RaceState.Crash:
                    Debug.Log("You hit a barrier. The race is over.");
                    break;

                case RaceState.Finish:
                    Debug.Log("You crossed the finish line. Well done!");
                    break;
                
                //undefined state
                default:
                    Debug.Log("This state is not defined. Something is wrong.");
                    break;
            }
        }

        // Use the Update() method to call the SimulateRace() method, allowing real-time updates when the raceState variable is modified in the Unity Inspector.
        void Update()
        {
            SimulateRace();
        }
    }
}
