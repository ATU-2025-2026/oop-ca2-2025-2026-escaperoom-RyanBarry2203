using System;

public class Room : Bedroom
{
	public Bedroom()
	{
	}
    public void DrawBedroom()
    {
        Console.WriteLine(
    "   ┌─────────────────────────────────────────────┐\n" +
    "   │                SPOOKY BEDROOM               │\n" +
    "   ├─────────────────────────────────────────────┤\n" +
    "   │       ______________________________        │\n" +
    "   │      |           ____            ___ |      │\n" +
    "   │      |          /    \\          /   \\|      │\n" +
    "   │      |   ___   | (  ) |   ___   |   ||      │\n" +
    "   │      |  |   |   \\____/   |   |  |___||      │\n" +
    "   │      |  |___|            |___|       |      │\n" +
    "   │      |________________________________|     │\n" +
    "   │                                             │\n" +
    "   │   A dusty bed sits crooked against the wall.│\n" +
    "   │   The wardrobe door hangs slightly open…    │\n" +
    "   │   Something moves in the darkness.          │\n" +
    "   └─────────────────────────────────────────────┘");
    }

}
