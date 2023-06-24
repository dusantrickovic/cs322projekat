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
            DefaultRoomDescription = " {0} {1}";

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
                "Upon entering the room, you find yourself in a rather average, normal looking dungeon. Nothing here really stands out. You see doors to",
                "As you step into the room, an icy chill permeates the air, causing a shiver to run down your spine. The temperature drops noticeably, and you wonder how is this even possible. Is there some magic involved? You see doors to",
                "Upon entering the room, a gentle warmth washes over you, wrapping you in a comforting embrace, which is something you did not expect. Despite your wishes to stay here and rest, you look around and see doors to",
                "As you step into the room, a shroud of darkness envelops you, obscuring your surroundings. The absence of light makes it challenging to discern any details, but you notice doors to",
                "Stepping into the room, your eyes are momentarily dazzled by the brilliance of the light flooding the space. You see doors to",
                "As you cautiously enter the room, the sight that greets you is one of desolation and ruin. The walls, once sturdy and proud, now bear the scars of time and neglect. With effort and causion you can make it to doors to",
                "You find yourself standing in a dimly lit room, the air heavy with an ominous aura. You shrug off the eerie feeling and see there are doors to"
            };
        }
    }
}
