using UnityEngine;

namespace Assignment18
{
    //Define a new class CharacterTest inheriting from MonoBehaviour for testing.
    public class CharacterTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Inside CharacterTest, create instances of Soldier and Officer, storing them in a Character[] array.
            Character[] characters = new Character[2];
            //USe the default constructor for Soldier.
            characters[0] = new Soldier();

            //Use the parameterized constructor for Officer
            Position officerPosition = new Position(0,1,2);
            characters[1] = new Officer("Ghost", 100, officerPosition);

            //Use a for loop to call DisplayInfo() on each element in the array, demonstrating polymorphism.
            for(int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            //Make the object of Officer attack the object of Soldier and output the Soldier's Health before and after the attack.
            Debug.Log("Soldier Health before attack: " + characters[0].Health);
            characters[1].Attack(35, characters[0], "Shooting");
            Debug.Log("Soldier Health after being attacked: " + characters[0].Health);
        }
    }
}
