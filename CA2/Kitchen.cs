using System;

namespace CA2
{
    // Correct inheritance: Kitchen IS A Room
    public class Kitchen : Room
    {
        // Unique properties for Kitchen
        public string KitchenItems { get; set; }
        public string KitchenPuzzle { get; set; }

        public Kitchen()
        {
            RoomName = "Kitchen";
            Description = "A strong smell of rot hangs in the air.";
            Puzzle = "Find the Key";
        }

        // Using 'override' lets this replace the generic Room Draw method
        public override void Draw()
        {
            Console.WriteLine(
            "   ┌─────────────────────────────────────────────┐\n" +
            "   │                     KITCHEN                 │\n" +
            "   ├─────────────────────────────────────────────┤\n" +
            "   │    _______             _______              │\n" +
            "   │   |   ___ |   ___     | ___   |             │\n" +
            "   │   |  |   ||  |   |    | |  |  |             │\n" +
            "   │   |  |___||  |___|    | |__|  |             │\n" +
            "   │   |_______|           |_______|             │\n" +
            "   │                                             │\n" +
            "   │  Pots and pans sway gently on their hooks.  │\n" +
            "   │  A strong smell of rot hangs in the air.    │\n" +
            "   │  Something just scurried behind the fridge. │\n" +
            "   └─────────────────────────────────────────────┘");

            // Automatically start the kitchen interaction
            InteractWithKitchen();
        }

        public void InteractWithKitchen()
        {
            bool roomOptionsExhausted = false;
            int interactionCount = 0;

            while (roomOptionsExhausted == false)
            {
                if (interactionCount >= 4)
                {
                    Console.WriteLine("You have searched everywhere here...");
                    roomOptionsExhausted = true;
                    break;
                }

                Console.WriteLine(
                "   ┌───────────────────────────────────────────────┐\n" +
                "   │                KITCHEN ACTIONS                │\n" +
                "   ├───────────────────────────────────────────────┤\n" +
                "   │ What would you like to do?                    │\n" +
                "   │                                               │\n" +
                "   │   [1] Check behind the fridge                 │\n" +
                "   │   [2] Search the drawer                       │\n" +
                "   │   [3] Search the cupboard                     │\n" +
                "   │   [4] Turn on the light                       │\n" +
                "   │   [0] Leave Menu                              │\n" +
                "   │                                               │\n" +
                "   │   Choose an option by typing its number.      │\n" +
                "   └───────────────────────────────────────────────┘");

                string input = Console.ReadLine();
                int option = 0;

                // Safely try to parse the number to prevent crashing
                int.TryParse(input, out option);

                if (option == 0) break;

                if (option == 1)
                {
                    Console.WriteLine(
                    "┌───────────────────────────────────────────┐\n" +
                    "│         CHECKING BEHIND THE FRIDGE        │\n" +
                    "├───────────────────────────────────────────┤\n" +
                    "│ You slowly pull the fridge away from the  │\n" +
                    "│ wall…                                     │\n" +
                    "│                                           │\n" +
                    "│   Something skitters out of sight—        │\n" +
                    "│   quick, light footfalls fading into      │\n" +
                    "│   the darkness.                           │\n" +
                    "│                                           │\n" +
                    "│ Beneath the dust and grime, you spot a    │\n" +
                    "│ small electrical fuse. It looks like it   │\n" +
                    "│ could be important later.                 │\n" +
                    "└───────────────────────────────────────────┘");
                }
                else if (option == 2)
                {
                    Console.WriteLine(
                    "┌───────────────────────────────────────────────────────────┐\n" +
                    "│                       SEARCHING DRAWER                    │\n" +
                    "├───────────────────────────────────────────────────────────┤\n" +
                    "│ You pull open the old wooden drawer. Its hinges creak     │\n" +
                    "│ loudly, echoing around the kitchen.                       │\n" +
                    "│                                                           │\n" +
                    "│ Inside you find scattered utensils and a torn note…       │\n" +
                    "│ The note reads: “THEY WATCH FROM THE DARK.”               │\n" +
                    "└───────────────────────────────────────────────────────────┘\n");
                }
                else if (option == 3)
                {
                    Console.WriteLine(
                    "┌───────────────────────────────────────────────────────────┐\n" +
                    "│                      SEARCHING CUPBOARD                   │\n" +
                    "├───────────────────────────────────────────────────────────┤\n" +
                    "│ You open the cupboard slowly. The smell of stale food     │\n" +
                    "│ and mildew rushes out to greet you.                       │\n" +
                    "│                                                           │\n" +
                    "│ Among old tins and cracked plates, you discover a small   │\n" +
                    "│ metal key. Its surface is ice-cold to the touch.          │\n" +
                    "└───────────────────────────────────────────────────────────┘\n");
                }
                else if (option == 4)
                {
                    Console.WriteLine(
                    "┌───────────────────────────────────────────────────────────┐\n" +
                    "│                         TURNING ON LIGHT                  │\n" +
                    "├───────────────────────────────────────────────────────────┤\n" +
                    "│ You flick the switch.                                     │\n" +
                    "│ The light stutters… flickers… then buzzes weakly to life. │\n" +
                    "│                                                           │\n" +
                    "│ The room is dim, but clearer now. Shadows retreat —       │\n" +
                    "│ all except one in the far corner… still unmoving.         │\n" +
                    "└───────────────────────────────────────────────────────────┘\n");
                }

                interactionCount++;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}