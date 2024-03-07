namespace Inventory;

public class Inventory
{
    private List<Item> _items = new List<Item>();

    private int _maxWeight;
    private int _weight;

    public int MaxWeight => _maxWeight;

    public int Weight => _weight;

    public Inventory(int maxWeight)
    {
        _maxWeight = maxWeight;
    }
    
    public bool AddItem(Item item, int count)
    {
        if (_weight + item.Weight * count > _maxWeight)
        {
            return false;
        }

        for (int i = 0; i < count; i++)
        {
            _items.Add(item);
        }

        _weight += item.Weight * count;

        return true;
    }

    public bool RemoveItem(Item item)
    {
        return _items.Remove(item);
    }

    public int CountItem(Item countItem)
    {
        int c = 0;
        for (var i = 0; i <= _items.Count; i++)
        {
            var item = _items[i];
            c++;
        }

        return c;
    }
    
    
}