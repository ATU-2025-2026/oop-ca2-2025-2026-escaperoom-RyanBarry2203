namespace CA2
{
    internal class Program
    {
        //start adding game logic here
        static void Main(string[] args)
        {
            DrawRoom("bedroom");
            
        }
        public void DrawRoom(string name)
        {
            switch (name.ToLower())
            {
                case "bedroom": DrawBedroom(); break;
                case "attic": DrawAttic(); break;
                case "study": DrawStudy(); break;
                case "kitchen": DrawKitchen(); break;
            }
        }

    }
}
