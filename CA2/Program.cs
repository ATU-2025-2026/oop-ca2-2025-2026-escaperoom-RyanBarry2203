using System;

namespace CA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example: Start the game in the Kitchen to test your menu logic
            Console.WriteLine("Welcome to the Escape Room.");
            DrawRoom("kitchen");

            // You can add a loop here later to let the user move between rooms
        }

        public static void DrawRoom(string name)
        {
            // Create a variable to hold the current room
            Room currentRoom = null;

            switch (name.ToLower())
            {
                case "bedroom":
                    currentRoom = new Bedroom();
                    break;
                case "attic":
                    currentRoom = new Attic();
                    break;
                case "study":
                    currentRoom = new Study();
                    break;
                case "kitchen":
                    currentRoom = new Kitchen();
                    break;
                default:
                    Console.WriteLine("That room does not exist.");
                    return;
            }

            // Now that we have the room, we draw it.
            // This works for ANY room because they all inherit from Room.
            if (currentRoom != null)
            {
                currentRoom.Draw();
            }
        }
    }
}