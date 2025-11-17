using System;

public class Room : Attic
{
	public Attic()
	{
	}
    public void DrawAttic()
    {
        Console.WriteLine(
    "   ┌──────────────────────────────────────────────┐\n" +
    "   │                  THE ATTIC                   │\n" +
    "   ├──────────────────────────────────────────────┤\n" +
    "   │      /\\                 /\\                   │\n" +
    "   │     /  \\_______________/  \\                  │\n" +
    "   │    /   /               \\   \\                 │\n" +
    "   │   /   /   ( )     ( )   \\   \\                │\n" +
    "   │   \\   \\      ___         /   /               │\n" +
    "   │    \\   \\    /___\\       /   /                │\n" +
    "   │     \\   \\______________/   /                 │\n" +
    "   │                                              │\n" +
    "   │  Cobwebs hang from every beam. The floor     │\n" +
    "   │  creaks with each step. A chained chest      │\n" +
    "   │  sits ominously in the corner.               │\n" +
    "   └──────────────────────────────────────────────┘");
    }

}
