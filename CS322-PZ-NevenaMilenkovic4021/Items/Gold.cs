namespace Gork
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
                var ending = Value == 1 ? MyText.Language.Coin : MyText.Language.Coins;
                return string.Format(MyText.Language.Gold, Value.ToString(), ending);
            }
        }
        public int Value { get; set; }
    }
}
