using System;

namespace CA2
{
    public class Finalroom : Room
    {
        public Finalroom()
        {
            RoomName = "Final Room";
            Description = "A heavy iron door stands before you. Is this the way out?";
        }

        public override void Draw()
        {
            Console.WriteLine(
            "   ┌──────────────────────────────────────────────┐\n" +
            "   │                 FINAL ROOM                   │\n" +
            "   ├──────────────────────────────────────────────┤\n" +
            "   │                                              │\n" +
            "   │      _______                     _______     │\n" +
            "   │     |       |                   |       |    │\n" +
            "   │     |   E   |    ___________    |   T   |    │\n" +
            "   │     |_______|   |   EXIT    |   |_______|    │\n" +
            "   │                 |___________|                │\n" +
            "   │                                              │\n" +
            "   │    The air is cold. The silence is loud.     │\n" +
            "   │    You have reached the end... or have you?  │\n" +
            "   └──────────────────────────────────────────────┘");
        }
    }
}