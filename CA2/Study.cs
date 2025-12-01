using System;

namespace CA2
{
    public class Study : Room
    {
        public Study()
        {
            RoomName = "Study";
            Description = "Books and scrolls litter the desk.";
        }

        public override void Draw()
        {
            Console.WriteLine(
            "   ┌──────────────────────────────────────────────┐\n" +
            "   │                     STUDY                    │\n" +
            "   ├──────────────────────────────────────────────┤\n" +
            "   │    ________________________________          │\n" +
            "   │   |    █████████   CODE LOCK  ███████ |      │\n" +
            "   │   |    [ 0 ] [ 0 ] [ 0 ] [ 0 ]        |      │\n" +
            "   │   |_________________________________|        │\n" +
            "   │                                              │\n" +
            "   │  Books and scrolls litter the desk. A lamp   │\n" +
            "   │  flickers softly, casting long shadows.      │\n" +
            "   │  A note reads: 'THE TRUTH IS IN THE TITLES.' │\n" +
            "   └──────────────────────────────────────────────┘");
        }
    }
}