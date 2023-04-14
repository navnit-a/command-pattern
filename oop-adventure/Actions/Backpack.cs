using oop_adventure.Items;

namespace oop_adventure.Actions
{
    public class Backpack : Action
    {
        private readonly IInventory _inventory;

        public Backpack(IInventory inventory)
        {
            _inventory = inventory;
        }

        public override string Name => Text.Text.Language.Backpack;

        public override void Execute(string[] args)
        {
            var items = _inventory.InventoryList;

            if (items.Length == 0)
            {
                Console.WriteLine(Text.Text.Language.BackpackError);

                return;

            }

            var list = Text.Text.Language.JoinedWordList(items, Text.Text.Language.And);
            Console.WriteLine(Text.Language.BackpackDescription, list);

        }
    }
}
