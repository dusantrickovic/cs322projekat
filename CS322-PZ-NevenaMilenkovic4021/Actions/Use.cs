using CS322_PZ_NevenaMilenkovic4021;

namespace Gork
{
    public class Use : Action
    {
        private readonly House _house;

        public Use(House house)
        {
            _house = house;
        }

        public override string Name => MyText.Language.Use;

        public override void Execute(string[] args)
        {
            if (args.Length < 1)
            {
                Game.game.lb.Items.Add(MyText.Language.UseError);
                return;
            }

            var itemName = args[1];

            if (_house.Player.Contains(itemName))
            {
                var item = _house.Player.Take(itemName);
                Game.game.lb.Items.Add(string.Format(MyText.Language.UseSuccess, item.Name));

                item.Use(itemName);
            }
            else
            {
                Game.game.lb.Items.Add(MyText.Language.UseError);
            }
        }
    }
}
