using CS322_PZ_NevenaMilenkovic4021;

namespace Gork
{
    public class Chest : Item, IInventory
    {
        private readonly House _house;
        private readonly Inventory _inventory = new();

        public override string Name => MyText.Language.Chest;
        public bool Locked => true;

        public Chest(Item?[] items, House house)
        {
            CanTake = false;
            _house = house;

            foreach (var item in items)
            {
                Add(item);
            }
        }

        public override void Use(string source)
        {
            if (source == MyText.Language.Key)
            {
                var items = InventoryList;

                if (Locked)
                    Game.game.lb.Items.Add(MyText.Language.UnlockChest);

                if (items.Length == 0)
                {
                    Game.game.lb.Items.Add(MyText.Language.ChestEmpty);
                }
                else
                {
                    Game.game.lb.Items.Add(string.Format(MyText.Language.ChestFound, MyText.Language.JoinedWordList(items, MyText.Language.And)));

                    foreach (var itemName in items)
                    {
                        var item = Take(itemName);
                        _house.Player.Add(item);
                    }
                }
            }
        }

        public int Total => ((IInventory)_inventory).Total;

        public string[] InventoryList => ((IInventory)_inventory).InventoryList;

        public void Add(Item item)
        {
            ((IInventory)_inventory).Add(item);
        }

        public bool Contains(string itemName)
        {
            return ((IInventory)_inventory).Contains(itemName);
        }

        public Item? Find(string itemName)
        {
            return ((IInventory)_inventory).Find(itemName);
        }

        public Item? Find(string itemName, bool remove)
        {
            return ((IInventory)_inventory).Find(itemName, remove);
        }

        public void Remove(Item item)
        {
            ((IInventory)_inventory).Remove(item);
        }

        public Item? Take(string itemName)
        {
            return ((IInventory)_inventory).Take(itemName);
        }

        public void Use(string itemName, string source)
        {
            ((IInventory)_inventory).Use(itemName, source);
        }
    }
}
