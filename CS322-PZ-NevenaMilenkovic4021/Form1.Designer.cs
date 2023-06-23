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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_d20 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d20)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_command
            // 
            this.txt_command.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_command.Location = new System.Drawing.Point(45, 476);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(466, 36);
            this.txt_command.TabIndex = 0;
            this.txt_command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_command_KeyDown);
            // 
            // lb_game
            // 
            this.lb_game.FormattingEnabled = true;
            this.lb_game.ItemHeight = 15;
            this.lb_game.Location = new System.Drawing.Point(45, 31);
            this.lb_game.Name = "lb_game";
            this.lb_game.Size = new System.Drawing.Size(466, 409);
            this.lb_game.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(532, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 287);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.pb_d20.Location = new System.Drawing.Point(569, 352);
            this.pb_d20.Name = "pb_d20";
            this.pb_d20.Size = new System.Drawing.Size(150, 160);
            this.pb_d20.TabIndex = 4;
            this.pb_d20.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pb_d20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_game);
            this.Controls.Add(this.txt_command);
            this.Name = "Game";
            this.Text = "Gork";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_command;
        private ListBox lb_game;
        private PictureBox pictureBox1;
        private PictureBox pb_d20;
    }
}