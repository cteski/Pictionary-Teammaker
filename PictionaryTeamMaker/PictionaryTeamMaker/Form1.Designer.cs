namespace PictionaryTeamMaker
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewPlayerBox = new System.Windows.Forms.TextBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.RemovePlayer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TeamsListBox = new System.Windows.Forms.ListBox();
            this.MakeTeamsButton = new System.Windows.Forms.Button();
            this.RemoveDrawer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DrawersList = new System.Windows.Forms.ListBox();
            this.AddDrawerButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NewDrawerBox = new System.Windows.Forms.TextBox();
            this.RemoveGuesser = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GuessersList = new System.Windows.Forms.ListBox();
            this.AddGuesserButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.NewGuesserBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewPlayerBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Player";
            // 
            // NewPlayerBox
            // 
            this.NewPlayerBox.Location = new System.Drawing.Point(7, 20);
            this.NewPlayerBox.Name = "NewPlayerBox";
            this.NewPlayerBox.Size = new System.Drawing.Size(117, 20);
            this.NewPlayerBox.TabIndex = 0;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(149, 30);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(34, 23);
            this.AddPlayerButton.TabIndex = 1;
            this.AddPlayerButton.Text = ">>";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PlayersListBox);
            this.groupBox2.Location = new System.Drawing.Point(200, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Players";
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.Location = new System.Drawing.Point(7, 17);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(128, 95);
            this.PlayersListBox.TabIndex = 0;
            // 
            // RemovePlayer
            // 
            this.RemovePlayer.Location = new System.Drawing.Point(119, 69);
            this.RemovePlayer.Name = "RemovePlayer";
            this.RemovePlayer.Size = new System.Drawing.Size(75, 23);
            this.RemovePlayer.TabIndex = 3;
            this.RemovePlayer.Text = "Remove";
            this.RemovePlayer.UseVisualStyleBackColor = true;
            this.RemovePlayer.Click += new System.EventHandler(this.RemovePlayer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TeamsListBox);
            this.groupBox3.Location = new System.Drawing.Point(347, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 347);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teams";
            // 
            // TeamsListBox
            // 
            this.TeamsListBox.FormattingEnabled = true;
            this.TeamsListBox.Location = new System.Drawing.Point(7, 20);
            this.TeamsListBox.Name = "TeamsListBox";
            this.TeamsListBox.Size = new System.Drawing.Size(315, 316);
            this.TeamsListBox.TabIndex = 0;
            // 
            // MakeTeamsButton
            // 
            this.MakeTeamsButton.Location = new System.Drawing.Point(347, 10);
            this.MakeTeamsButton.Name = "MakeTeamsButton";
            this.MakeTeamsButton.Size = new System.Drawing.Size(330, 53);
            this.MakeTeamsButton.TabIndex = 5;
            this.MakeTeamsButton.Text = "TEAM UP";
            this.MakeTeamsButton.UseVisualStyleBackColor = true;
            this.MakeTeamsButton.Click += new System.EventHandler(this.MakeTeamsButton_Click);
            // 
            // RemoveDrawer
            // 
            this.RemoveDrawer.Location = new System.Drawing.Point(119, 205);
            this.RemoveDrawer.Name = "RemoveDrawer";
            this.RemoveDrawer.Size = new System.Drawing.Size(75, 23);
            this.RemoveDrawer.TabIndex = 9;
            this.RemoveDrawer.Text = "Remove";
            this.RemoveDrawer.UseVisualStyleBackColor = true;
            this.RemoveDrawer.Click += new System.EventHandler(this.RemoveDrawer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DrawersList);
            this.groupBox4.Location = new System.Drawing.Point(200, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 127);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drawers";
            // 
            // DrawersList
            // 
            this.DrawersList.FormattingEnabled = true;
            this.DrawersList.Location = new System.Drawing.Point(7, 17);
            this.DrawersList.Name = "DrawersList";
            this.DrawersList.Size = new System.Drawing.Size(128, 95);
            this.DrawersList.TabIndex = 0;
            // 
            // AddDrawerButton
            // 
            this.AddDrawerButton.Location = new System.Drawing.Point(149, 166);
            this.AddDrawerButton.Name = "AddDrawerButton";
            this.AddDrawerButton.Size = new System.Drawing.Size(34, 23);
            this.AddDrawerButton.TabIndex = 7;
            this.AddDrawerButton.Text = ">>";
            this.AddDrawerButton.UseVisualStyleBackColor = true;
            this.AddDrawerButton.Click += new System.EventHandler(this.AddDrawerButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NewDrawerBox);
            this.groupBox5.Location = new System.Drawing.Point(13, 149);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 50);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New Player";
            // 
            // NewDrawerBox
            // 
            this.NewDrawerBox.Location = new System.Drawing.Point(7, 20);
            this.NewDrawerBox.Name = "NewDrawerBox";
            this.NewDrawerBox.Size = new System.Drawing.Size(117, 20);
            this.NewDrawerBox.TabIndex = 0;
            // 
            // RemoveGuesser
            // 
            this.RemoveGuesser.Location = new System.Drawing.Point(119, 342);
            this.RemoveGuesser.Name = "RemoveGuesser";
            this.RemoveGuesser.Size = new System.Drawing.Size(75, 23);
            this.RemoveGuesser.TabIndex = 13;
            this.RemoveGuesser.Text = "Remove";
            this.RemoveGuesser.UseVisualStyleBackColor = true;
            this.RemoveGuesser.Click += new System.EventHandler(this.RemoveGuesser_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.GuessersList);
            this.groupBox6.Location = new System.Drawing.Point(200, 286);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(141, 127);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Guessers";
            // 
            // GuessersList
            // 
            this.GuessersList.FormattingEnabled = true;
            this.GuessersList.Location = new System.Drawing.Point(7, 17);
            this.GuessersList.Name = "GuessersList";
            this.GuessersList.Size = new System.Drawing.Size(128, 95);
            this.GuessersList.TabIndex = 0;
            // 
            // AddGuesserButton
            // 
            this.AddGuesserButton.Location = new System.Drawing.Point(149, 303);
            this.AddGuesserButton.Name = "AddGuesserButton";
            this.AddGuesserButton.Size = new System.Drawing.Size(34, 23);
            this.AddGuesserButton.TabIndex = 11;
            this.AddGuesserButton.Text = ">>";
            this.AddGuesserButton.UseVisualStyleBackColor = true;
            this.AddGuesserButton.Click += new System.EventHandler(this.AddGuesserButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.NewGuesserBox);
            this.groupBox7.Location = new System.Drawing.Point(13, 286);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(130, 50);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "New Player";
            // 
            // NewGuesserBox
            // 
            this.NewGuesserBox.Location = new System.Drawing.Point(7, 20);
            this.NewGuesserBox.Name = "NewGuesserBox";
            this.NewGuesserBox.Size = new System.Drawing.Size(117, 20);
            this.NewGuesserBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 428);
            this.Controls.Add(this.RemoveGuesser);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.AddGuesserButton);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.RemoveDrawer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AddDrawerButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.MakeTeamsButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RemovePlayer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NewPlayerBox;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RemovePlayer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.ListBox TeamsListBox;
        private System.Windows.Forms.Button MakeTeamsButton;
        private System.Windows.Forms.Button RemoveDrawer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox DrawersList;
        private System.Windows.Forms.Button AddDrawerButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox NewDrawerBox;
        private System.Windows.Forms.Button RemoveGuesser;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox GuessersList;
        private System.Windows.Forms.Button AddGuesserButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox NewGuesserBox;
    }
}

