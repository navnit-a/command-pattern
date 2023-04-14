using oop_adventure.Items;

namespace oop_adventure.Text.Characters
{
    public class Player : Character, IInventory
    {
        private readonly Inventory _inventory;

        public Player(string name) : base(name)
        {
            _inventory = new Inventory();
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
}
