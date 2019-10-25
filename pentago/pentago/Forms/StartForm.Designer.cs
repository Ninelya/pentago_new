namespace pentago.Forms
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label_sectors_number = new System.Windows.Forms.Label();
            this.label_players_number = new System.Windows.Forms.Label();
            this.cbSectorCount = new System.Windows.Forms.ComboBox();
            this.cbPlayerCount = new System.Windows.Forms.ComboBox();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.tbName3 = new System.Windows.Forms.TextBox();
            this.tbName4 = new System.Windows.Forms.TextBox();
            this.tbName5 = new System.Windows.Forms.TextBox();
            this.tbName6 = new System.Windows.Forms.TextBox();
            this.tbName7 = new System.Windows.Forms.TextBox();
            this.tbName8 = new System.Windows.Forms.TextBox();
            this.button_new_game = new System.Windows.Forms.Button();
            this.ballCyan = new System.Windows.Forms.PictureBox();
            this.ballYellow = new System.Windows.Forms.PictureBox();
            this.ballBrown = new System.Windows.Forms.PictureBox();
            this.ballRed = new System.Windows.Forms.PictureBox();
            this.ballBlue = new System.Windows.Forms.PictureBox();
            this.ballMagenta = new System.Windows.Forms.PictureBox();
            this.ballBlack = new System.Windows.Forms.PictureBox();
            this.ballGreen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ballCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballMagenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label_sectors_number
            // 
            this.label_sectors_number.AutoSize = true;
            this.label_sectors_number.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sectors_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.label_sectors_number.Location = new System.Drawing.Point(6, 16);
            this.label_sectors_number.Name = "label_sectors_number";
            this.label_sectors_number.Size = new System.Drawing.Size(0, 15);
            this.label_sectors_number.TabIndex = 1;
            // 
            // label_players_number
            // 
            this.label_players_number.AutoSize = true;
            this.label_players_number.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_players_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.label_players_number.Location = new System.Drawing.Point(6, 53);
            this.label_players_number.Name = "label_players_number";
            this.label_players_number.Size = new System.Drawing.Size(0, 15);
            this.label_players_number.TabIndex = 3;
            // 
            // cbSectorCount
            // 
            this.cbSectorCount.FormattingEnabled = true;
            this.cbSectorCount.Items.AddRange(new object[] {
            "4 (2 х 2)",
            "9 (3 х 3)",
            "16 (4 х 4)",
            "25 (5 х 5)"});
            this.cbSectorCount.Location = new System.Drawing.Point(198, 13);
            this.cbSectorCount.Name = "cbSectorCount";
            this.cbSectorCount.Size = new System.Drawing.Size(121, 21);
            this.cbSectorCount.TabIndex = 10;
            // 
            // cbPlayerCount
            // 
            this.cbPlayerCount.FormattingEnabled = true;
            this.cbPlayerCount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbPlayerCount.Location = new System.Drawing.Point(198, 50);
            this.cbPlayerCount.MaxLength = 1;
            this.cbPlayerCount.Name = "cbPlayerCount";
            this.cbPlayerCount.Size = new System.Drawing.Size(121, 21);
            this.cbPlayerCount.TabIndex = 11;
            this.cbPlayerCount.SelectedIndexChanged += new System.EventHandler(this.cbPlayerCount_SelectedIndexChanged);
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(58, 112);
            this.tbName1.MaxLength = 9;
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(92, 20);
            this.tbName1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tbName1, "Введите имя");
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(227, 112);
            this.tbName2.MaxLength = 9;
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(92, 20);
            this.tbName2.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tbName2, "Введите имя");
            // 
            // tbName3
            // 
            this.tbName3.Enabled = false;
            this.tbName3.Location = new System.Drawing.Point(58, 159);
            this.tbName3.MaxLength = 9;
            this.tbName3.Name = "tbName3";
            this.tbName3.Size = new System.Drawing.Size(92, 20);
            this.tbName3.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tbName3, "Введите имя");
            // 
            // tbName4
            // 
            this.tbName4.Enabled = false;
            this.tbName4.Location = new System.Drawing.Point(227, 159);
            this.tbName4.MaxLength = 9;
            this.tbName4.Name = "tbName4";
            this.tbName4.Size = new System.Drawing.Size(92, 20);
            this.tbName4.TabIndex = 15;
            this.toolTip1.SetToolTip(this.tbName4, "Введите имя");
            // 
            // tbName5
            // 
            this.tbName5.Enabled = false;
            this.tbName5.Location = new System.Drawing.Point(58, 207);
            this.tbName5.MaxLength = 9;
            this.tbName5.Name = "tbName5";
            this.tbName5.Size = new System.Drawing.Size(92, 20);
            this.tbName5.TabIndex = 16;
            this.toolTip1.SetToolTip(this.tbName5, "Введите имя");
            // 
            // tbName6
            // 
            this.tbName6.Enabled = false;
            this.tbName6.Location = new System.Drawing.Point(227, 207);
            this.tbName6.MaxLength = 9;
            this.tbName6.Name = "tbName6";
            this.tbName6.Size = new System.Drawing.Size(92, 20);
            this.tbName6.TabIndex = 17;
            this.toolTip1.SetToolTip(this.tbName6, "Введите имя");
            // 
            // tbName7
            // 
            this.tbName7.Enabled = false;
            this.tbName7.Location = new System.Drawing.Point(58, 256);
            this.tbName7.MaxLength = 9;
            this.tbName7.Name = "tbName7";
            this.tbName7.Size = new System.Drawing.Size(92, 20);
            this.tbName7.TabIndex = 18;
            this.toolTip1.SetToolTip(this.tbName7, "Введите имя");
            // 
            // tbName8
            // 
            this.tbName8.Enabled = false;
            this.tbName8.Location = new System.Drawing.Point(227, 256);
            this.tbName8.MaxLength = 9;
            this.tbName8.Name = "tbName8";
            this.tbName8.Size = new System.Drawing.Size(92, 20);
            this.tbName8.TabIndex = 19;
            this.toolTip1.SetToolTip(this.tbName8, "Введите имя");
            // 
            // button_new_game
            // 
            this.button_new_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.button_new_game.FlatAppearance.BorderSize = 0;
            this.button_new_game.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new_game.Location = new System.Drawing.Point(217, 334);
            this.button_new_game.Name = "button_new_game";
            this.button_new_game.Size = new System.Drawing.Size(102, 23);
            this.button_new_game.TabIndex = 20;
            this.button_new_game.UseVisualStyleBackColor = false;
            this.button_new_game.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ballCyan
            // 
            this.ballCyan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballCyan.BackgroundImage")));
            this.ballCyan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballCyan.Location = new System.Drawing.Point(183, 152);
            this.ballCyan.Name = "ballCyan";
            this.ballCyan.Size = new System.Drawing.Size(35, 35);
            this.ballCyan.TabIndex = 53;
            this.ballCyan.TabStop = false;
            // 
            // ballYellow
            // 
            this.ballYellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballYellow.BackgroundImage")));
            this.ballYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballYellow.Location = new System.Drawing.Point(183, 200);
            this.ballYellow.Name = "ballYellow";
            this.ballYellow.Size = new System.Drawing.Size(35, 35);
            this.ballYellow.TabIndex = 52;
            this.ballYellow.TabStop = false;
            // 
            // ballBrown
            // 
            this.ballBrown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballBrown.BackgroundImage")));
            this.ballBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballBrown.Location = new System.Drawing.Point(183, 249);
            this.ballBrown.Name = "ballBrown";
            this.ballBrown.Size = new System.Drawing.Size(35, 35);
            this.ballBrown.TabIndex = 51;
            this.ballBrown.TabStop = false;
            // 
            // ballRed
            // 
            this.ballRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballRed.BackgroundImage")));
            this.ballRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballRed.Location = new System.Drawing.Point(15, 105);
            this.ballRed.Name = "ballRed";
            this.ballRed.Size = new System.Drawing.Size(35, 35);
            this.ballRed.TabIndex = 50;
            this.ballRed.TabStop = false;
            // 
            // ballBlue
            // 
            this.ballBlue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballBlue.BackgroundImage")));
            this.ballBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballBlue.Location = new System.Drawing.Point(15, 152);
            this.ballBlue.Name = "ballBlue";
            this.ballBlue.Size = new System.Drawing.Size(35, 35);
            this.ballBlue.TabIndex = 49;
            this.ballBlue.TabStop = false;
            // 
            // ballMagenta
            // 
            this.ballMagenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballMagenta.BackgroundImage")));
            this.ballMagenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballMagenta.Location = new System.Drawing.Point(15, 200);
            this.ballMagenta.Name = "ballMagenta";
            this.ballMagenta.Size = new System.Drawing.Size(35, 35);
            this.ballMagenta.TabIndex = 48;
            this.ballMagenta.TabStop = false;
            // 
            // ballBlack
            // 
            this.ballBlack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballBlack.BackgroundImage")));
            this.ballBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballBlack.Location = new System.Drawing.Point(15, 249);
            this.ballBlack.Name = "ballBlack";
            this.ballBlack.Size = new System.Drawing.Size(35, 35);
            this.ballBlack.TabIndex = 47;
            this.ballBlack.TabStop = false;
            // 
            // ballGreen
            // 
            this.ballGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballGreen.BackgroundImage")));
            this.ballGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballGreen.Location = new System.Drawing.Point(183, 105);
            this.ballGreen.Name = "ballGreen";
            this.ballGreen.Size = new System.Drawing.Size(35, 35);
            this.ballGreen.TabIndex = 46;
            this.ballGreen.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(342, 373);
            this.Controls.Add(this.ballCyan);
            this.Controls.Add(this.ballYellow);
            this.Controls.Add(this.ballBrown);
            this.Controls.Add(this.ballRed);
            this.Controls.Add(this.ballBlue);
            this.Controls.Add(this.ballMagenta);
            this.Controls.Add(this.ballBlack);
            this.Controls.Add(this.ballGreen);
            this.Controls.Add(this.button_new_game);
            this.Controls.Add(this.tbName8);
            this.Controls.Add(this.tbName7);
            this.Controls.Add(this.tbName6);
            this.Controls.Add(this.tbName5);
            this.Controls.Add(this.tbName4);
            this.Controls.Add(this.tbName3);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.tbName1);
            this.Controls.Add(this.cbPlayerCount);
            this.Controls.Add(this.cbSectorCount);
            this.Controls.Add(this.label_players_number);
            this.Controls.Add(this.label_sectors_number);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ballCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballMagenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sectors_number;
        private System.Windows.Forms.Label label_players_number;
        private System.Windows.Forms.ComboBox cbSectorCount;
        private System.Windows.Forms.ComboBox cbPlayerCount;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.TextBox tbName3;
        private System.Windows.Forms.TextBox tbName4;
        private System.Windows.Forms.TextBox tbName5;
        private System.Windows.Forms.TextBox tbName6;
        private System.Windows.Forms.TextBox tbName7;
        private System.Windows.Forms.TextBox tbName8;
        private System.Windows.Forms.Button button_new_game;
        private System.Windows.Forms.PictureBox ballCyan;
        private System.Windows.Forms.PictureBox ballYellow;
        private System.Windows.Forms.PictureBox ballBrown;
        private System.Windows.Forms.PictureBox ballRed;
        private System.Windows.Forms.PictureBox ballBlue;
        private System.Windows.Forms.PictureBox ballMagenta;
        private System.Windows.Forms.PictureBox ballBlack;
        private System.Windows.Forms.PictureBox ballGreen;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}