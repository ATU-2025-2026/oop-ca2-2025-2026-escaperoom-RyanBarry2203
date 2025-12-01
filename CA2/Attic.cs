using System;

namespace CA2
{
    public class Attic : Room
    {
        public Attic()
        {
            RoomName = "Attic";
            Description = "Cobwebs hang from every beam.";
        }

        public override void Draw()
        {
            Console.WriteLine(
            "   ┌──────────────────────────────────────────────┐\n" +
            "   │                  THE ATTIC                   │\n" +
            "   ├──────────────────────────────────────────────┤\n" +
            "   │       /\\                  /\\                 │\n" +
            "   │      /  \\_______________/  \\                 │\n" +
            "   │     /   /                \\   \\               │\n" +
            "   │    /   /    ( )      ( )    \\   \\            │\n" +
            "   │    \\   \\       ___          /   /            │\n" +
            "   │     \\   \\     /___\\        /   /             │\n" +
            "   │      \\   \\______________/   /                │\n" +
            "   │                                              │\n" +
            "   │  Cobwebs hang from every beam. The floor     │\n" +
            "   │  creaks with each step. A chained chest      │\n" +
            "   │  sits ominously in the corner.               │\n" +
            "   └──────────────────────────────────────────────┘");
        }
    }
}