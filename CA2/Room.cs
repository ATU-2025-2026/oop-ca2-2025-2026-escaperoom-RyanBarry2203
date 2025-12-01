using System;

namespace CA2
{
    public class Room
    {
        // Properties belong here (inside the class, outside the constructor)
        public string Puzzle { get; set; }
        public string Description { get; set; }
        public string RoomName { get; set; }
        public string Gimmick { get; set; }

        public Room()
        {
            // Initialize default values to avoid null warnings
            Puzzle = "None";
            Description = "A generic room.";
            RoomName = "Unknown";
            Gimmick = "None";
        }

        // Virtual method allows subclasses (like Kitchen) to override it
        public virtual void Draw()
        {
            Console.WriteLine($"You are in the {RoomName}.");
            Console.WriteLine(Description);
        }

        public override string ToString()
        {
            return
                "┌───────────────────────────────────────────────┐\n" +
                $"│ ROOM: {RoomName,-40} │\n" +
                "├───────────────────────────────────────────────┤\n" +
                $"│ Description:                                  │\n" +
                $"│   {Description,-42} │\n" +
                "│                                               │\n" +
                $"│ Puzzle: {Puzzle,-37}│\n" +
                "│                                               │\n" +
                "├───────────────────────────────────────────────┤\n" +
                "│ Actions:                                      │\n" +
                "│   [1] Inspect Room                            │\n" +
                "│   [2] Solve Puzzle                            │\n" +
                "│   [3] Check Inventory                         │\n" +
                "│   [4] Move to Next Room                       │\n" +
                "└───────────────────────────────────────────────┘\n";
        }
    }
}