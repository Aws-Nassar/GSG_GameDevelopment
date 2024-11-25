using UnityEngine;

namespace Assignment14
{
    public class Character
    {
        //string Name: The character's name
        private string name;

        //int Health: The character's health
        private int health;

        //Use getters and setters for both properties to control and protect the information stored in them.
        public string Name {
            get 
            { 
                return name;  
            }
            set
            {
                name = value;
            }  
        }

        public int Health {
            get 
            { 
                return health;  
            }
            set
            {
                health = value;
                //set health max and mix value
                if(health > 100)
                {
                    health = 100;
                }
                else if(health < 0)
                {
                    health = 0;
                }
            }  
        }

        //Make a constructor to set up the character's Name and Health when the character is created.
        public Character(string name, int health)
        {
            this.name = name;
            this.health = health;
        }
    }
}
