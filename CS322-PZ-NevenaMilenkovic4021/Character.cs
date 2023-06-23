using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_PZ_NevenaMilenkovic4021
{
    public partial class Character : Form
    {
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
            this.Hide();
            Game game = new Game();
            game.Show();
        }
    }
}
