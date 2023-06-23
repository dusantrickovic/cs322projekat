using Gork;

namespace CS322_PZ_NevenaMilenkovic4021
{
    public partial class Game : Form
    {
        string input;

        string name = "Neru"; //will read from database later

        House house;
        Room lastRoom;

        public static Game game;
        public ListBox lb;
        public Game()
        {
            InitializeComponent();
            game = this;
            lb = lb_game;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            MyText.LoadLanguage(new English());

            Utils.ReadFile("./welcome.txt", lb_game);

            var player = new Player(name);
            lb_game.Items.Add(string.Format(MyText.Language.Welcome, name));

            house = new House(player);
            house.CreateRooms(3, 3);
            house.DecorateRooms();

            var items = new List<Item>()
            {
                new Key(house),
                new Chest(new[] { new Gold(100) }, house)
            };

            house.PopulateRooms(items);

            Actions.Instance.Register(new Go(house));
            Actions.Instance.Register(new Backpack(player));
            Actions.Instance.Register(new Take(house));
            Actions.Instance.Register(new Use(house));

            house.GoToStartingRoom();

            lastRoom = null;

            lb_game.Items.Add(house.CurrentRoom.ToString());

            lb_game.Items.Add(MyText.Language.WhatToDo);
        }

        private void txt_command_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                input = txt_command.Text.ToLower();

                if (input == MyText.Language.Quit)
                    Application.Exit();
                else
                    Actions.Instance.Execute(input.Split(" "));

                if (lastRoom != house.CurrentRoom)
                {
                    lb_game.Items.Add(house.CurrentRoom.ToString());
                    lastRoom = house.CurrentRoom;
                }

                lb_game.Items.Add(MyText.Language.WhatToDo);

                txt_command.Clear();
            }
        }

    }
}