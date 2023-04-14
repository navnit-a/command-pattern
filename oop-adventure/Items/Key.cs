using oop_adventure.Map;

namespace oop_adventure.Items
{
    public class Key : Item
    {
        private readonly House _house;

        public Key(House house)
        {
            _house = house;

            CanTake = true;
            SingleUse = true;
        }

        public override string Name { get; set; } = Text.Text.Language.Key;

        public override void Use(string source)
        {
            _house.CurrentRoom.Use(Text.Text.Language.Chest, Name);
        }
    }
}
