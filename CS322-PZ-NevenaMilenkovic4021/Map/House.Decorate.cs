namespace Gork
{
    public partial class House
    {
        public void DecorateRooms()
        {
            foreach (var room in Rooms)
            {
                var roomDescription = MyText.Language.RoomDescriptions[0];

                if (MyText.Language.RoomDescriptions.Count > 1 && _rnd.Next(0, 2) == 1)
                {
                    roomDescription = MyText.Language.RoomDescriptions[_rnd.Next(1, MyText.Language.RoomDescriptions.Count)];
                    MyText.Language.RoomDescriptions.Remove(roomDescription);
                }

                room.Description = String.Format(MyText.Language.DefaultRoomDescription, roomDescription, "{0}");
            }
        }

        public void PopulateRooms(List<Item> items)
        {
            var i = 0;
            while (i != items.Count)
            {
                var room = Rooms[_rnd.Next(0, Rooms.Length)];

                if (room.Total == 0)
                {
                    room.Add(items[i]);
                    i++;
                }
            }
        }
    }
}