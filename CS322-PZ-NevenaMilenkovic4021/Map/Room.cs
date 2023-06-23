using System.Text;

namespace Gork
{
    public class Room : IInventory
    {
        private readonly IInventory _inventory = new Inventory();
        public string Name { get; set; } = MyText.Language.DefaultRoomName;
        public string Description { get; set; } = MyText.Language.DefaultRoomDescription;

        public Dictionary<Directions, int> Neighbors { get; set; } = new()
        {
            { Directions.North, -1 },
            { Directions.East, -1 },
            { Directions.South, -1 },
            { Directions.West, -1 },
            { Directions.None, -1}
        };

        public bool Visited { get; set; }

        public int Total => _inventory.Total;

        public string[] InventoryList => _inventory.InventoryList;

        public void Add(Item item)
        {
            _inventory.Add(item);
        }

        public bool Contains(string itemName)
        {
            return _inventory.Contains(itemName);
        }

        public Item? Find(string itemName)
        {
            return _inventory.Find(itemName);
        }

        public Item? Find(string itemName, bool remove)
        {
            return _inventory.Find(itemName, remove);
        }

        public void Remove(Item item)
        {
            _inventory.Remove(item);
        }

        public Item? Take(string itemName)
        {
            return _inventory.Take(itemName);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Visited)
                sb.Append(string.Format(MyText.Language.RoomOld, Name));
            else
                sb.Append(string.Format(MyText.Language.RoomNew, Name));

            var names = Enum.GetNames(typeof(Directions));
            var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();
            var description = string.Format(Description, MyText.Language.JoinedWordList(directions, MyText.Language.And));

            sb.Append(description);

            if (_inventory.Total > 0)
            {
                var items = _inventory.InventoryList;

                var pluralPre = items.Length > 1 ? MyText.Language.Are : MyText.Language.Is;
                var pluralPost = items.Length > 1 ? MyText.Language.Plural : "";

                sb.Append(string.Format(MyText.Language.TotalItems, pluralPre, items.Length, pluralPost));
                sb.Append(MyText.Language.JoinedWordList(items, MyText.Language.And) + MyText.Language.Period);
            }

            return sb.ToString();
        }

        public void Use(string itemName, string source)
        {
            _inventory.Use(itemName, source);
        }
    }
}
