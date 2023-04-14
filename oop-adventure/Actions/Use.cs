using oop_adventure.Items;
using oop_adventure.Map;

namespace oop_adventure.Actions
{
    public class Use : Action
    {
        private readonly House _house;

        public Use(House house)
        {
            _house = house;
        }

        public override string Name => Text.Text.Language.Use;

        public override void Execute(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine(Text.Text.Language.UseError);
                return;
            }

            var itemName = args[1];

            if (_house.Player.Contains(itemName))
            {
                var item = _house.Player.Take(itemName);
                Console.WriteLine(Text.Text.Language.UseSuccess, item.Name);
                item.Use(itemName);
            }
            else
            {
                Console.WriteLine(Text.Text.Language.UseError);

            }
        }
    }
}
