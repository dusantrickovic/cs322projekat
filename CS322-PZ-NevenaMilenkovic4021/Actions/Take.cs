using CS322_PZ_NevenaMilenkovic4021;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gork
{
    public class Take : Action
    {
        private readonly House _house;

        public Take(House house)
        {
            _house = house;
        }

        public override string Name => MyText.Language.Take;
        public override void Execute(string[] args)
        {
            if (args.Length == 1)
            {
                Game.game.lb.Items.Add(MyText.Language.NotTaken);
                return;
            }

            var inventory = _house.CurrentRoom;
            var itemName = args[1].ToLower();

            if (inventory.Contains(itemName))
            {
                var item = inventory.Take(itemName);
                if (item.CanTake)
                {
                    _house.Player.Add(item);
                    Game.game.lb.Items.Add(string.Format(MyText.Language.TookDescription, item.Name));
                }
                else
                {
                    Game.game.lb.Items.Add(string.Format(MyText.Language.CantTakeDescription, item.Name));
                }

                return;
            }

            Game.game.lb.Items.Add(MyText.Language.TakeError);
        }

    }
}
