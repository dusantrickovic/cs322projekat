namespace CS322_PZ_NevenaMilenkovic4021
{
    partial class Character
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Character));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_race_info = new System.Windows.Forms.Label();
            this.lbl_race = new System.Windows.Forms.Label();
            this.btn_start_adventure = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_dice = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_name.Font = new System.Drawing.Font("Xolonium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_name.Location = new System.Drawing.Point(59, 43);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(144, 48);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_race_info
            // 
            this.lbl_race_info.AutoSize = true;
            this.lbl_race_info.Location = new System.Drawing.Point(573, 67);
            this.lbl_race_info.Name = "lbl_race_info";
            this.lbl_race_info.Size = new System.Drawing.Size(74, 20);
            this.lbl_race_info.TabIndex = 1;
            this.lbl_race_info.Text = "Race info:";
            // 
            // lbl_race
            // 
            this.lbl_race.AutoSize = true;
            this.lbl_race.BackColor = System.Drawing.Color.Transparent;
            this.lbl_race.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_race.Font = new System.Drawing.Font("Xolonium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_race.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_race.Location = new System.Drawing.Point(59, 116);
            this.lbl_race.Name = "lbl_race";
            this.lbl_race.Size = new System.Drawing.Size(127, 48);
            this.lbl_race.TabIndex = 2;
            this.lbl_race.Text = "Race";
            // 
            // btn_start_adventure
            // 
            this.btn_start_adventure.BackColor = System.Drawing.Color.Transparent;
            this.btn_start_adventure.FlatAppearance.BorderSize = 0;
            this.btn_start_adventure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_adventure.Font = new System.Drawing.Font("Xolonium", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start_adventure.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_start_adventure.Location = new System.Drawing.Point(96, 636);
            this.btn_start_adventure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_start_adventure.Name = "btn_start_adventure";
            this.btn_start_adventure.Size = new System.Drawing.Size(717, 96);
            this.btn_start_adventure.TabIndex = 3;
            this.btn_start_adventure.Text = "Start adventure";
            this.btn_start_adventure.UseVisualStyleBackColor = false;
            this.btn_start_adventure.Click += new System.EventHandler(this.btn_start_adventure_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(208, 63);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(138, 27);
            this.txt_name.TabIndex = 4;
            // 
            // btn_dice
            // 
            this.btn_dice.BackColor = System.Drawing.Color.Transparent;
            this.btn_dice.BackgroundImage = global::CS322_PZ_NevenaMilenkovic4021.Properties.Resources.dice;
            this.btn_dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dice.FlatAppearance.BorderSize = 0;
            this.btn_dice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dice.Location = new System.Drawing.Point(375, 49);
            this.btn_dice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dice.Name = "btn_dice";
            this.btn_dice.Size = new System.Drawing.Size(46, 55);
            this.btn_dice.TabIndex = 5;
            this.btn_dice.Text = " ";
            this.btn_dice.UseVisualStyleBackColor = false;
            this.btn_dice.Click += new System.EventHandler(this.btn_dice_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 136);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS322_PZ_NevenaMilenkovic4021.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(896, 748);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_dice);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_start_adventure);
            this.Controls.Add(this.lbl_race);
            this.Controls.Add(this.lbl_race_info);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Character";
            this.Text = "Character";
            this.Load += new System.EventHandler(this.Character_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private Label lbl_race_info;
        private Label lbl_race;
        private Button btn_start_adventure;
        private TextBox txt_name;
        private Button btn_dice;
        private ComboBox comboBox1;
    }
}