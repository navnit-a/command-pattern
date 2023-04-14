using System.Text;
using oop_adventure.Items;

namespace oop_adventure.Map;

public class Room : IInventory
{
    public string Name { get; set; } = Text.Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Text.Language.DefaultRoomDescription;

    private readonly IInventory _inventory = new Inventory();

    public Dictionary<Directions, int> Neighbours { get; set; } = new()
    {
        { Directions.North, -1 },
        { Directions.South, -1 },
        { Directions.East, -1 },
        { Directions.West, -1 },
        { Directions.None, -1 }
    };

    public bool Visited { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        if (Visited)
        {
            sb.Append(string.Format(Text.Text.Language.RoomOld, Name));
        }
        else
        {
            sb.Append(string.Format(Text.Text.Language.RoomNew, Name));
        }

        var names = Enum.GetNames(typeof(Directions));

        var directions =
            (from p in names where Neighbours[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower())
            .ToArray();

        var description = string.Format(Description,
            Text.Text.Language.JoinedWordList(directions, Text.Text.Language.And));

        sb.Append(description);

        if (_inventory.Total > 0)
        {
            var items = _inventory.InventoryList;

            var pluralPre = items.Length > 1 ? Text.Text.Language.Are : Text.Text.Language.Is;

            var pluralPost = items.Length > 1 ? Text.Text.Language.Plural : "";

            sb.Append(string.Format(Text.Text.Language.TotalItems, pluralPre, items.Length, pluralPost));

            sb.Append(Text.Text.Language.JoinedWordList(items, Text.Text.Language.And) + Text.Text.Language.Period);
        }

        return sb.ToString();
    }

    public int Total => _inventory.Total;
    public string[] InventoryList => _inventory.InventoryList;

    public void Add(Item item)
    {
        _inventory.Add(item);
    }

    public void Remove(Item item)
    {
        _inventory.Remove(item);
    }

    public Item? Find(string itemName)
    {
        return _inventory.Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return _inventory.Find(itemName, remove);
    }

    public bool Contains(string itemName)
    {
        return _inventory.Contains(itemName);
    }

    public Item? Take(string itemName)
    {
        return _inventory.Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        _inventory.Use(itemName, source);
    }
}