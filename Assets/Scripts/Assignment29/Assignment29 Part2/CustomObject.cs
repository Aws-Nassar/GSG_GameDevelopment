using UnityEngine;

namespace Assignment292
{
    public class CustomObject
    {
        //Properties: ID (integer),Name (string).
        private int id;
        private string name;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        //A constructor to initialize ID and Name.
        public CustomObject (int id = -1, string name = "Empty")
        {
            ID = id;
            Name = name;
        }

        //An overridden ToString() method that returns a formatted string
        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }

        //An overridden Equals(object obj) method to compare two CustomObject instances.
        /*
        public override bool Equals(object obj)
        {
            CustomObject castObj = obj as CustomObject;
            if(castObj != null)
            {
                return (this.ID == castObj.ID && this.Name.Equals(castObj.Name));
            }
            return false;
        }
        */

        //Overloaded == and != operators to check equality between two objects of type CustomObject.
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if(!obj1.Equals(null) && !obj2.Equals(null))
            {
                return (obj1.ID == obj2.ID && obj1.Name.Equals(obj2.Name));
            }
            return false;
        }

        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
