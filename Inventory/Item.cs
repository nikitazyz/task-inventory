namespace Inventory;

public class Item
{
    public string Name { get; }
    public int Weight { get; }

    public Item(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }
}