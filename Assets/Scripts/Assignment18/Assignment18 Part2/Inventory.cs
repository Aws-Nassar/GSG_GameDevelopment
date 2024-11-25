using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment182
{
    //Create a class Inventory
    public class Inventory
    {
        //Create a private List<string> to store item names.
        private List<string> items = new List<string>(); 

        //Add a method AddItem(string item) to add an item to the list.
        public void AddItem(string item)
        {
            this.items.Add(item);
        }

        //Add a method ShowItems() to log all items in the inventory.
        public void ShowItems()
        {
            //If the list is empty
            if(this.items.Count == 0)
            {
                Debug.Log("Your inventory is empty.");
            }

            //If the list contains at least one item
            else
            {
                Debug.Log("Your inventory contain/s those item/s:");
                foreach(object n in items)
                {
                    Debug.Log("--> " + n);
                }
            }
        }

        //Overload the + operator: This should combine two Inventory objects into one, containing all items from both (duplicates are allowed).
        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory c = new Inventory();
            c.items.AddRange(a.items);
            c.items.AddRange(b.items);

            return c;
        }
    } 
}
