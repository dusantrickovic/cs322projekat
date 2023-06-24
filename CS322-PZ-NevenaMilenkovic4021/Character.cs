using MySql.Data.MySqlClient;

namespace CS322_PZ_NevenaMilenkovic4021
{
    public partial class Character : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password='';database=cs322");
        public Character()
        {
            InitializeComponent();
        }

        private void btn_dice_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_name.Text = Utils.ReadJson();
        }

        private void btn_start_adventure_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO player (name, race) VALUES ('Ryven', 'Aasimar')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Close();

            this.Hide();
            Game game = new Game();
            game.Show();
        }

        private void Character_Load(object sender, EventArgs e)
        {
                conn.Open();
        }
    }
}
