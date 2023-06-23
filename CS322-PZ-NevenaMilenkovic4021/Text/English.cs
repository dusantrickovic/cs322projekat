namespace Gork
{
    public class English : Language
    {
        public English()
        {
            Welcome = "Welcome {0} to this adventure!";
            ChooseYourName = "What is your name hero?";
            DefaultName = "No name";

            DefaultRoomName = "Room {0} ({1}, {2})";
            DefaultRoomDescription = " You are in a {0} room with doors to {1}";

            ActionError = "You can't do that.";

            Go = "Go";
            GoError = "You can't go there.";

            WhatToDo = "What will you do next hero?";
            Quit = "quit";

            RoomNew = "You entered {0}";
            RoomOld = "You return to {0}";

            And = "and";
            Comma = ",";
            Space = " ";

            NoItem = "You don't have {0}";

            Backpack = "Backpack";
            BackpackError = "You do not have anything in your backpack";
            BackpackDescription = "Your backpack contains: {0}.";

            Chest = "chest";
            UnlockChest = "You unlocked the chest.";
            Key = "key";
            ChestEmpty = "The chest is empty.";
            ChestFound = "You found: {0}";

            Gold = "{0} gold {1}";
            Coin = "coin";
            Coins = Coin + "s";

            Plural = "s";
            Is = "is";
            Are = "are";
            TotalItems = " There are {0} {1} item{2} in the room.";

            Period = ".";

            Take = "Take";
            TakeError = "There is nothing to take.";
            NotTaken = "You can't take that.";
            TookDescription = "You took a {0}";
            CantTakeDescription = "You can't take the {0}";

            Use = "Use";
            UseSuccess = "You used the {0}";
            UseError = "You can't use that.";

            RoomDescriptions = new List<string>
            {
                "normal",
                "cold",
                "warm",
                "dark",
                "bright",
                "ruined",
                "ominous"
            };
        }
    }
}
