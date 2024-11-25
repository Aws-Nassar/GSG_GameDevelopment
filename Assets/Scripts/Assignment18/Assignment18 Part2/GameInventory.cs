using UnityEngine;

namespace Assignment182
{
    //Create a script GameInventory that inherits from MonoBehaviour.
    public class GameInventory : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Create an inventory for potions and add "Healing Potion" and "Strength Potion".
            Inventory potions = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");

            //Create another inventory for elixirs and add "Elixir" and "Dark Elixir".
            Inventory elixir = new Inventory();
            elixir.AddItem("Elixir");
            elixir.AddItem("Dark Elixir");

            //Combine both inventories using the + operator.
            Inventory combinedInventory = potions + elixir;

            //Use ShowItems() to display the items in the combined inventory.
            combinedInventory .ShowItems();
        }
    }
}
