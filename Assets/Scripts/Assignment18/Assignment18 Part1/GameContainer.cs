using UnityEngine;

namespace Assignment181
{
    //Create a class GameContainer<T>
    public class GameContainer<T>
    {
        //This class can store one item of any type (like a number or a string).
        private T item;

        //Add a method SetItem(T item) to save an item in the GameContainer.
        public void SetItem(T item)
        {
            this.item = item;
        }

        //Add another method GetItem() to return the saved item.
        public T GetItem()
        {
            return this.item;
        }
    }  
}
