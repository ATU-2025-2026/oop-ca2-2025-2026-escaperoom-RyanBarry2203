using System;

public class Player
{
	public Player()
	{
		public string currentRoom { get; set; }
		public string inventory { get; set; }
		public int health { get; set; }
		public int sanity { get; set; }
	public Player()
		{
			// Default constructor
		}
		public Player(string currentRoom, string inventory, int health, int sanity)
		{
			this.currentRoom = currentRoom;
			this.inventory = inventory;
			this.health = health;
			this.sanity = sanity;
    }
}
}
