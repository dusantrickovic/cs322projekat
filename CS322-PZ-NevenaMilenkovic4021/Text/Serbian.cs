namespace Gork
{
    public class Serbian : Language
    {
        public Serbian()
        {
            Welcome = "Dobrodošao {0}! Avantura počinje!";
            ChooseYourName = "Kako se zoveš hrabri heroju?";
            DefaultName = "Bezimeni";

            DefaultRoomName = "Soba {0} ({1}, {2})";
            DefaultRoomDescription = " Nalaziš se u {0} sobi sa vratima ka {1}";

            ActionError = "Ovo nije moguće.";

            Go = "Idi";
            GoError = "Ne možeš da odeš tamo.";

            WhatToDo = "Šta je sledeće hrabri heroju?";
            Quit = "izlaz";

            RoomNew = "Ušao si u sobu {0}";
            RoomOld = "Vratio si se u sobu {0}";

            And = "i";
            Comma = ",";
            Space = " ";

            NoItem = "Ne poseduješ {0}";

            Backpack = "Ranac";
            BackpackError = "Tvoj ranac je prazan";
            BackpackDescription = "Sadržaj ranca: {0}.";

            Chest = "sanduk";
            UnlockChest = "Otključao si sanduk.";
            Key = "ključ";
            ChestEmpty = "Sanduk je prazan.";
            ChestFound = "Našao si: {0}";

            Gold = "{0} novčić {1}";
            Coin = "novčić";
            Coins = Coin + "a";

            Plural = "i";
            Is = "je";
            Are = "su";
            TotalItems = " There are {0} {1} stvar{2} u sobi.";

            Period = ".";

            Take = "Uzmi";
            TakeError = "Nema ničega za uzimanje.";
            NotTaken = "To nije moguće uzeti.";
            TookDescription = "Uzeo si {0}";
            CantTakeDescription = "Ne možeš da uzmeš {0}";

            Use = "Koristi";
            UseSuccess = "Iskoristio si {0}";
            UseError = "Ne možeš to da koristiš.";

            RoomDescriptions = new List<string>
            {
                "normalnoj",
                "hladnoj",
                "toploj",
                "mračnoj",
                "svetloj",
                "strašnoj",
                "čudnoj"
            };
        }
    }
}

