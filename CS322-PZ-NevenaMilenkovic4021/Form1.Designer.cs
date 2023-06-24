namespace CS322_PZ_NevenaMilenkovic4021
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_command = new System.Windows.Forms.TextBox();
            this.lb_game = new System.Windows.Forms.ListBox();
            this.pb_env = new System.Windows.Forms.PictureBox();
            this.pb_d20 = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.pb_env)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d20)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_command
            // 
            this.txt_command.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_command.Location = new System.Drawing.Point(45, 664);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(753, 36);
            this.txt_command.TabIndex = 0;
            this.txt_command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_command_KeyDown);
            // 
            // lb_game
            // 
            this.lb_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_game.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_game.ForeColor = System.Drawing.Color.PaleGreen;
            this.lb_game.FormattingEnabled = true;
            this.lb_game.ItemHeight = 19;
            this.lb_game.Location = new System.Drawing.Point(45, 31);
            this.lb_game.Name = "lb_game";
            this.lb_game.Size = new System.Drawing.Size(753, 593);
            this.lb_game.TabIndex = 2;
            // 
            // pb_env
            // 
            this.pb_env.Location = new System.Drawing.Point(828, 31);
            this.pb_env.Name = "pb_env";
            this.pb_env.Size = new System.Drawing.Size(320, 320);
            this.pb_env.TabIndex = 3;
            this.pb_env.TabStop = false;
            // 
            // pb_d20
            // 
            this.pb_d20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_d20.BackColor = System.Drawing.Color.Transparent;
            this.pb_d20.BackgroundImage = global::CS322_PZ_NevenaMilenkovic4021.Properties.Resources.d20;
            this.pb_d20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_d20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_d20.InitialImage = global::CS322_PZ_NevenaMilenkovic4021.Properties.Resources.d20;
            this.pb_d20.Location = new System.Drawing.Point(890, 466);
            this.pb_d20.Name = "pb_d20";
            this.pb_d20.Size = new System.Drawing.Size(225, 234);
            this.pb_d20.TabIndex = 4;
            this.pb_d20.TabStop = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::CS322_PZ_NevenaMilenkovic4021.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.pb_d20);
            this.Controls.Add(this.pb_env);
            this.Controls.Add(this.lb_game);
            this.Controls.Add(this.txt_command);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.Text = "Gork";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_env)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_command;
        private ListBox lb_game;
        private PictureBox pb_env;
        private PictureBox pb_d20;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}