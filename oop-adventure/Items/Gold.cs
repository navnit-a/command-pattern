namespace oop_adventure.Items
{
    public class Gold : Item
    {
        public Gold(int value)
        {
            Value = value;
            CanTake = true;
            
        }

        public override string Name
        {
            get
            {
                var ending = Value == 1 ? Text.Text.Language.Coin : Text.Text.Language.Coins;

                return string.Format(Text.Text.Language.Gold, Value.ToString(), ending);
            }
        }

        public int Value { get; set; }
    }
}
