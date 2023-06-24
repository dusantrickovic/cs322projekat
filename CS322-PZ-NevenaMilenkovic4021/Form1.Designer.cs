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
            ((System.ComponentModel.ISupportInitialize)(this.pb_env)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d20)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_command
            // 
            this.txt_command.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_command.Location = new System.Drawing.Point(51, 635);
            this.txt_command.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(735, 43);
            this.txt_command.TabIndex = 0;
            this.txt_command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_command_KeyDown);
            // 
            // lb_game
            // 
            this.lb_game.FormattingEnabled = true;
            this.lb_game.ItemHeight = 20;
            this.lb_game.Location = new System.Drawing.Point(51, 41);
            this.lb_game.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_game.Name = "lb_game";
            this.lb_game.Size = new System.Drawing.Size(735, 544);
            this.lb_game.TabIndex = 2;
            // 
            // pb_env
            // 
            this.pb_env.Location = new System.Drawing.Point(860, 41);
            this.pb_env.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_env.Name = "pb_env";
            this.pb_env.Size = new System.Drawing.Size(361, 383);
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
            this.pb_d20.Location = new System.Drawing.Point(941, 465);
            this.pb_d20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_d20.Name = "pb_d20";
            this.pb_d20.Size = new System.Drawing.Size(200, 213);
            this.pb_d20.TabIndex = 4;
            this.pb_d20.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1284, 748);
            this.Controls.Add(this.pb_d20);
            this.Controls.Add(this.pb_env);
            this.Controls.Add(this.lb_game);
            this.Controls.Add(this.txt_command);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}