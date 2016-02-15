using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictionaryTeamMaker
{
    public partial class Form1 : Form
    {
        private List<String> Players = new List<string>();
        private List<String> Guessers = new List<string>();
        private List<String> Drawers = new List<string>();
        private List<String> Teams = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            if (NewPlayerBox.Text != "" 
                && (!Players.Contains(NewPlayerBox.Text)
                    && !Drawers.Contains(NewPlayerBox.Text)
                    && !Guessers.Contains(NewPlayerBox.Text)))
            {
                Players.Add(NewPlayerBox.Text);
                PlayersListBox.Items.Add(NewPlayerBox.Text);
                NewPlayerBox.Text = "";
            }
            UpdateTeamButton();
        }

        private void RemovePlayer_Click(object sender, EventArgs e)
        {
            if (Players.Contains((string)PlayersListBox.SelectedItem))
            {
                Players.Remove((string)PlayersListBox.SelectedItem);
                PlayersListBox.Items.Remove((string)PlayersListBox.SelectedItem);
            }
            UpdateTeamButton();
        }

        private void AddDrawerButton_Click(object sender, EventArgs e)
        {
            if (NewDrawerBox.Text != ""
                && (!Players.Contains(NewDrawerBox.Text)
                    && !Drawers.Contains(NewDrawerBox.Text)
                    && !Guessers.Contains(NewDrawerBox.Text)))
            {
                Drawers.Add(NewDrawerBox.Text);
                DrawersList.Items.Add(NewDrawerBox.Text);
                NewDrawerBox.Text = "";
            }
            UpdateTeamButton();
        }

        private void RemoveDrawer_Click(object sender, EventArgs e)
        {
            if (Drawers.Contains((string)DrawersList.SelectedItem))
            {
                Drawers.Remove((string)DrawersList.SelectedItem);
                DrawersList.Items.Remove((string)DrawersList.SelectedItem);
            }
            UpdateTeamButton();
        }

        private void AddGuesserButton_Click(object sender, EventArgs e)
        {
            if (NewGuesserBox.Text != ""
                && (!Players.Contains(NewGuesserBox.Text)
                    && !Drawers.Contains(NewGuesserBox.Text)
                    && !Guessers.Contains(NewGuesserBox.Text)))
            {
                Guessers.Add(NewGuesserBox.Text);
                GuessersList.Items.Add(NewGuesserBox.Text);
                NewGuesserBox.Text = "";
            }
            UpdateTeamButton();
        }

        private void RemoveGuesser_Click(object sender, EventArgs e)
        {
            if (Guessers.Contains((string)GuessersList.SelectedItem))
            {
                Guessers.Remove((string)GuessersList.SelectedItem);
                GuessersList.Items.Remove((string)GuessersList.SelectedItem);
            }
            UpdateTeamButton();
        }

        private void UpdateTeamButton()
        {
            if ((Players.Count + Guessers.Count + Drawers.Count) % 2 != 0)
            {
                MakeTeamsButton.Enabled = false;
            }
            else
            {
                MakeTeamsButton.Enabled = true;
            }
        }

        private void MakeTeamsButton_Click(object sender, EventArgs e)
        {
            int teamCount = (Players.Count + Guessers.Count + Drawers.Count) / 2;
            Random rnd = new Random();

            List<String> sortedPlayers = new List<string>(Players.OrderBy(x => rnd.Next()).ToList());
            List<String> sortedGuessers = new List<string>(Guessers.OrderBy(x => rnd.Next()).ToList());
            List<String> sortedDrawers = new List<string>(Drawers.OrderBy(x => rnd.Next()).ToList());

            for (int i = 0; i < sortedPlayers.Count; i++)
            {
                if (sortedGuessers.Count <= sortedDrawers.Count)
                {
                    sortedGuessers.Add(sortedPlayers[i]);
                }
                else
                {
                    sortedDrawers.Add(sortedPlayers[i]);
                }
            }

            sortedGuessers = new List<string>(sortedGuessers.OrderBy(x => rnd.Next()).ToList());
            sortedDrawers = new List<string>(sortedDrawers.OrderBy(x => rnd.Next()).ToList());

            for(int i = 0; i < teamCount; i++)
            {
                int GuesserIndex = rnd.Next(sortedGuessers.Count);
                String Guesser = sortedGuessers[GuesserIndex];
                sortedGuessers.RemoveAt(GuesserIndex);

                int DrawerIndex = rnd.Next(sortedDrawers.Count);
                String Drawer = sortedDrawers[DrawerIndex];
                sortedDrawers.RemoveAt(DrawerIndex);

                Teams.Add("Draw: " + Drawer + " Guess: " + Guesser);
            }

            List<String> sortedTeams = new List<string>(Teams.OrderBy(x => rnd.Next()).ToList());
            Teams.Clear();

            TeamsListBox.DataSource = sortedTeams;
        }
    }
}
