using CS322_PZ_NevenaMilenkovic4021;

namespace Gork
{
    public class Backpack : Action
    {
        private readonly IInventory _inventory;

        public Backpack(IInventory inventory)
        {
            _inventory = inventory;
        }

        public override string Name => MyText.Language.Backpack;

        public override void Execute(string[] args)
        {
            var items = _inventory.InventoryList;
            if (items.Length == 0)
            {
                Game.game.lb.Items.Add(MyText.Language.BackpackError);
                return;
            }

            var list = MyText.Language.JoinedWordList(items, MyText.Language.And);

            Game.game.lb.Items.Add(string.Format(MyText.Language.BackpackDescription, list));
        }
    }
}
