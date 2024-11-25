using UnityEngine;

//Within the same namespace, define a base class named Character.
namespace Assignment18
{
    //Create a Base Class Character
    public class Character
    {
        //Add a public string name field
        public string name;

        //Add a private int health field
        private int health = 0;

        //Add a protected Position position field
        protected Position position;

        //Create a Health property with custom logic to restrict health to a minimum of 0 and a maximum of 100.
        public int Health
        {
            set 
            {
                if(health > 100)
                {
                    health = 100;
                } 
                else if(health < 0)
                {
                    health = 0;
                }
                else{
                    health = value;
                }
            }

            get 
            {
                return health;
            }
        }

        //A parameterized constructor to initialize name, Health, and position.
        public Character(string characterName, int characterHealth, Position characterPosition)
        {
            this.name = characterName;
            this.Health = characterHealth;
            this.position = characterPosition;
        }

        //A default constructor that uses constructor chaining to call the parameterized constructor with default values
        public Character() : this("No name", 100, new Position(0,0,0))
        {

        }

        //Add a virtual DisplayInfo() method to display name, Health,
        public virtual void DisplayInfo()
        {
            Debug.Log("Character Name: " + this.name + " | Health: " + this.Health + " |");

            //use the printPosition() method from Position struct to output the position.
            position.printPosition();
        }

        //The first overload of Attack takes int damage and Character target, reducing the target's Health by the specified damage amount.
        public void Attack(int damage, Character target)
        {
            target.Health -= damage;
        }

        //The second overload takes int damage, Character target, and a string attackType (e.g., "shooting" or "kicking").
        public void Attack(int damage, Character target, string attackType)
        {
            //Apply the DRY principle to avoid code duplication between the two overloaded methods.
            Attack(damage, target);
            
            //This method performs the same action as the first overload, while additionally printing the attackType (no need to store it).
            Debug.Log(this.name + " attacked " + target.name + " by " +  attackType);
        }
    }
}
