using System;

public class Item
{
	public Item()
	{
		public string itemName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public string itemInteractable { get; set; }

    public Item()
    {
        // Default constructor

    }
    public Item(string itemName, string type, string description, int value, string itemInteractable)
    {
        this.itemName = itemName;
        this.Type = type;
        this.Description = description;
        this.Value = value;
        this.itemInteractable = itemInteractable;
    }
    public override string ToString()
    {
        return
            "+-----------------------+\n" +
            "|       ITEM INFO       |\n" +
            "+-----------------------+\n" +
            $"| Name:        {itemName,-10} |\n" +
            $"| Type:        {Type,-10} |\n" +
            $"| Description: {Description,-10} |\n" +
            $"| Value:       {Value,-10} |\n" +
            "+-----------------------+";
    }

}
