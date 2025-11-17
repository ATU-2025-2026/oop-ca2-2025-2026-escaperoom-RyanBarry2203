using System;

public class Room
{
	public Room()
	{
		public string puzzle { get; set; }
		public string description { get; set; }
		public string roomName { get; set; }
	public string gimmic { get; set; }
	public Room()
	{
		// Default constructor
	}
	public Room(string puzzle, string description, string roomName, string gimmic)
	{
		this.puzzle = puzzle;
		this.description = description;
		this.roomName = roomName;
		this.gimmic = gimmic;

    }
    public override string ToString()
    {
        return
            "┌───────────────────────────────────────────────┐\n" +
            $"│ ROOM: {roomName,-40} │\n" +
            "├───────────────────────────────────────────────┤\n" +
            $"│ Description:                                   │\n" +
            $"│   {description,-42} │\n" +
            "│                                               │\n" +
            $"│ Puzzle: {puzzle,-37}│\n" +
            "│                                               │\n" +
            "├───────────────────────────────────────────────┤\n" +
            "│ Actions:                                      │\n" +
            "│   [1] Inspect Room                            │\n" +
            "│   [2] Solve Puzzle                             │\n" +
            "│   [3] Check Inventory                          │\n" +
            "│   [4] Move to Next Room                        │\n" +
            "└───────────────────────────────────────────────┘\n";
    }

}
}
