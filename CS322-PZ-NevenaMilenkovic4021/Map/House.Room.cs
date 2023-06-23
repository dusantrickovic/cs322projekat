﻿namespace Gork
{
    public partial class House
    {
        private int CalculateRoomIndex(int c, int r)
        {
            return Math.Clamp(c, -1, Width) + Math.Clamp(r, -1, Height) * Width;
        }

        public void CreateRooms(int width, int height)
        {
            Width = Math.Clamp(width, 2, 10);
            Height = Math.Clamp(height, 2, 10);

            var total = Width * Height;

            Rooms = new Room[total];

            for (var i = 0; i < total; i++)
            {
                var tmpRoom = new Room();
                var c = i % Width; //kolona
                var r = i / Width; //red

                tmpRoom.Name = String.Format(MyText.Language.DefaultRoomName, i, c, r);

                if (c < Width - 1)
                {
                    tmpRoom.Neighbors[Directions.East] = CalculateRoomIndex(c + 1, r);
                }

                if (c > 0)
                {
                    tmpRoom.Neighbors[Directions.West] = CalculateRoomIndex(c - 1, r);
                }

                if (r < Height - 1)
                {
                    tmpRoom.Neighbors[Directions.South] = CalculateRoomIndex(c, r + 1);
                }

                if (r > 0)
                {
                    tmpRoom.Neighbors[Directions.North] = CalculateRoomIndex(c, r - 1);
                }

                Rooms[i] = tmpRoom;
            }
        }
    }
}