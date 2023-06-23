using CS322_PZ_NevenaMilenkovic4021;

namespace Gork
{
    public class Go : Action
    {
        public override string Name => MyText.Language.Go;

        private readonly House _house;

        public Go(House house)
        {
            _house = house;
        }

        public override void Execute(string[] args)
        {
            var currentRoom = _house.CurrentRoom;
            var dir = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();

            Enum.TryParse(dir, out Directions newDirection);

            var nextRoomIndex = currentRoom.Neighbors[newDirection];

            if (nextRoomIndex == -1 || newDirection == Directions.None)
                Game.game.lb.Items.Add(MyText.Language.GoError);
            else
                _house.GoToRoom(nextRoomIndex);
        }
    }
}
