namespace Gork
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

        public override string Name { get; set; } = MyText.Language.Key;

        public override void Use(string source)
        {
            _house.CurrentRoom.Use(MyText.Language.Chest, Name);
        }
    }
}
