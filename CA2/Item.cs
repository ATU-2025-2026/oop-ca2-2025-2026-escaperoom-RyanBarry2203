using System;

namespace CA2
{
    public class Item
    {
        // Properties fixed (moved outside constructor)
        public string ItemName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public string ItemInteractable { get; set; }

        public Item()
        {
            // Default constructor
        }

        public Item(string itemName, string type, string description, int value, string itemInteractable)
        {
            this.ItemName = itemName;
            this.Type = type;
            this.Description = description;
            this.Value = value;
            this.ItemInteractable = itemInteractable;
        }

        public override string ToString()
        {
            return
                "+-----------------------+\n" +
                "|        ITEM INFO      |\n" +
                "+-----------------------+\n" +
                $"| Name:        {ItemName,-10} |\n" +
                $"| Type:        {Type,-10} |\n" +
                $"| Description: {Description,-10} |\n" +
                $"| Value:       {Value,-10} |\n" +
                "+-----------------------+";
        }
    }
}