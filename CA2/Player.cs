using System;

namespace CA2
{
    public class Player
    {
        // Properties moved to class level
        public string CurrentRoom { get; set; }
        public string Inventory { get; set; }
        public int Health { get; set; }
        public int Sanity { get; set; }

        public Player()
        {
            // Default constructor
            Health = 100;
            Sanity = 100;
        }

        public Player(string currentRoom, string inventory, int health, int sanity)
        {
            this.CurrentRoom = currentRoom;
            this.Inventory = inventory;
            this.Health = health;
            this.Sanity = sanity;
        }
    }
}