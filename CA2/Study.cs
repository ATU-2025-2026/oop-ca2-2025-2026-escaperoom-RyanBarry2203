using System;

public class Room : Study
{
	public Study()
	{
	}
    public void DrawStudy()
    {
        Console.WriteLine(
    "   ┌──────────────────────────────────────────────┐\n" +
    "   │                    STUDY                     │\n" +
    "   ├──────────────────────────────────────────────┤\n" +
    "   │   ________________________________           │\n" +
    "   │  |   █████████  CODE LOCK  ███████ |         │\n" +
    "   │  |   [ 0 ] [ 0 ] [ 0 ] [ 0 ]       |         │\n" +
    "   │  |_________________________________|         │\n" +
    "   │                                              │\n" +
    "   │  Books and scrolls litter the desk. A lamp   │\n" +
    "   │  flickers softly, casting long shadows.      │\n" +
    "   │  A note reads: 'THE TRUTH IS IN THE TITLES.' │\n" +
    "   └──────────────────────────────────────────────┘");
    }

}
