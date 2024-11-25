using UnityEngine;

namespace Assignment181
{
    //Create a script GenericsTest that inherits from MonoBehaviour:
    public class GenericsTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Create a GameContainer<string> 
            GameContainer<string> container = new GameContainer<string>();

            //Store "Healing Potion" in container. 
            container.SetItem("Healing Potion");

            //Use GetItem() to log the saved item.
            Debug.Log("Stored item: " + container.GetItem());
            
            //Use DescribeItem<T>() to describe the saved item and log the description.
            Debug.Log(GameUtils.DescribeItem(container.GetItem()));

        }
    }
}
