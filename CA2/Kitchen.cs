using System;

public class Room : Kitchen
{
	public Kitchen()
	{
        public string KitchenItems { get; set; }
        public string KitchenPuzzle { get; set; }
}
    public void DrawKitchen()
    {
        Console.WriteLine(
    "   ┌─────────────────────────────────────────────┐\n" +
    "   │                    KITCHEN                  │\n" +
    "   ├─────────────────────────────────────────────┤\n" +
    "   │   _______            _______                │\n" +
    "   │  |  ___  |   ___    | ___  |               │\n" +
    "   │  | |   | |  |   |   | |   | |              │\n" +
    "   │  | |___| |  |___|   | |___| |              │\n" +
    "   │  |_______|          |_______|              │\n" +
    "   │                                             │\n" +
    "   │  Pots and pans sway gently on their hooks.  │\n" +
    "   │  A strong smell of rot hangs in the air.    │\n" +
    "   │  Something just scurried behind the fridge. │\n" +
    "   └─────────────────────────────────────────────┘");
    
    }
    public void DrawOption1()
{
    bool roomOptionsExhausted = false;
    int optionsExhausted = 0;
    bool   

    if (optionsExhausted == 4)
    {
        roomOptionsExhausted = true;
    }

    Console.WriteLine(
"   ┌───────────────────────────────────────────────┐\n" +
"   │               KITCHEN ACTIONS                │\n" +
"   ├───────────────────────────────────────────────┤\n" +
"   │ What would you like to do?                   │\n" +
"   │                                               │\n" +
"   │   [1] Check behind the fridge                 │\n" +
"   │   [2] Search the drawer                       │\n" +
"   │   [3] Search the cupboard                     │\n" +
"   │   [4] Turn on the light                       │\n" +
"   │                                               │\n" +
"   │   Choose an option by typing its number.      │\n" +
"   └───────────────────────────────────────────────┘");

    // take in user input and return the selected option
    const int option = int.Parse(Console.ReadLine());

    while (roomOptionsExhausted == false)
    {
        Console.WriteLine(
    "┌───────────────────────────────────────────┐\n" +
    "│        CHECKING BEHIND THE FRIDGE         │\n" +
    "├───────────────────────────────────────────┤\n" +
    "│ You slowly pull the fridge away from the   │\n" +
    "│ wall…                                       │\n" +
    "│                                             │\n" +
    "│   Something skitters out of sight—          │\n" +
    "│   quick, light footfalls fading into        │\n" +
    "│   the darkness.                              │\n" +
    "│                                             │\n" +
    "│ Beneath the dust and grime, you spot a      │\n" +
    "│ small electrical fuse. It looks like it     │\n" +
    "│ could be important later.                   │\n" +
    "└───────────────────────────────────────────┘");

        Console.WriteLine(
"   ┌───────────────────────────────────────────────┐\n" +
"   │               KITCHEN ACTIONS                │\n" +
"   ├───────────────────────────────────────────────┤\n" +
"   │ What would you like to do?                   │\n" +
"   │                                               │\n" +
"   │                                               │\n" +
"   │   [2] Search the drawer                       │\n" +
"   │   [3] Search the cupboard                     │\n" +
"   │   [4] Turn on the light                       │\n" +
"   │                                               │\n" +
"   │   Choose an option by typing its number.      │\n" +
"   └───────────────────────────────────────────────┘");
        const int option = int.Parse(Console.ReadLine());
        optionsExhausted++;
        continue;

    }
    if (option == 2)
    {
        Console.WriteLine(
        "┌───────────────────────────────────────────────────────────┐\n" +
        "│                      SEARCHING DRAWER                     │\n" +
        "├───────────────────────────────────────────────────────────┤\n" +
        "│ You pull open the old wooden drawer. Its hinges creak     │\n" +
        "│ loudly, echoing around the kitchen.                       │\n" +
        "│                                                           │\n" +
        "│ Inside you find scattered utensils and a torn note…       │\n" +
        "│ The note reads: “THEY WATCH FROM THE DARK.”                │\n" +
        "└───────────────────────────────────────────────────────────┘\n");
    }
    if (option == 3)
    {
        Console.WriteLine(
        "┌───────────────────────────────────────────────────────────┐\n" +
        "│                     SEARCHING CUPBOARD                    │\n" +
        "├───────────────────────────────────────────────────────────┤\n" +
        "│ You open the cupboard slowly. The smell of stale food     │\n" +
        "│ and mildew rushes out to greet you.                       │\n" +
        "│                                                           │\n" +
        "│ Among old tins and cracked plates, you discover a small   │\n" +
        "│ metal key. Its surface is ice-cold to the touch.          │\n" +
        "└───────────────────────────────────────────────────────────┘\n");
    }
    if (option == 4)
    {
        Console.WriteLine(
        "┌───────────────────────────────────────────────────────────┐\n" +
        "│                       TURNING ON LIGHT                    │\n" +
        "├───────────────────────────────────────────────────────────┤\n" +
        "│ You flick the switch.                                     │\n" +
        "│ The light stutters… flickers… then buzzes weakly to life. │\n" +
        "│                                                           │\n" +
        "│ The room is dim, but clearer now. Shadows retreat —       │\n" +
        "│ all except one in the far corner… still unmoving.         │\n" +
        "└───────────────────────────────────────────────────────────┘\n");
    }
}







}
