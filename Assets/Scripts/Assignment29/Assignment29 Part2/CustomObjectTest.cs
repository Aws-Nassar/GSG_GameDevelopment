using UnityEngine;

namespace Assignment292
{
    public class CustomObjectTest : MonoBehaviour
    {
        void Start()
        {
            //Instantiates one CustomObject instance with a specific ID and a Name.
            CustomObject game1 = new CustomObject(1, "CS:GO");

            //Logs the instance object using the print() method.
            print(game1);

            //Instantiates another CustomObject
            CustomObject game2 = new CustomObject(2, "VALORANT");

            //logs the results of comparing the objects using the == and != operators
            print($"Are {game1.Name} and {game2.Name} smilar? {game1 == game2}");
            print($"Are {game1.Name} and {game2.Name} good game? {game1 != game2}");
        }
    }
}
