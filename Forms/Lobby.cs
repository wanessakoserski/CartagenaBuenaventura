using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaBuenaventura.Classes;

namespace CartagenaBuenaventura.Forms
{
    public partial class Lobby : Screen
    {
        Match match;

        // Initialize match and if there is a player declares in match.player
        // Enable proper buttons: if you are a player, you can start the match
        // and if the matche already began, it can be shown the board
        public Lobby(Match match, Player player = null)
        {
            InitializeComponent();
            this.match = match;          

            if(player != null)
                this.match.user = player;
            
            if (this.match.user == null) { btnStartMatch.Enabled = false; }

            if (this.match.status == enums.MatchStatus.InProgress) 
                btnGoToBoard.Enabled = true; 
            else 
                btnGoToBoard.Enabled = false;

            SetListPlayers();
        }

        // Sets the information to create the players list on the screen
        private void SetListPlayers()
        {
            lstPlayers.GridLines = true;
            lstPlayers.View = View.Details;
            lstPlayers.FullRowSelect = true;

            lstPlayers.Columns.Add("Id", 50, HorizontalAlignment.Center);
            lstPlayers.Columns.Add("Nome", 100, HorizontalAlignment.Center);
            lstPlayers.Columns.Add("Cor", 100, HorizontalAlignment.Center);

            ShowListPlayers();
        }

        // Clean the current data in list
        // Fill the players list with current data from server
        private void ShowListPlayers()
        {
            this.match.players = Game.ListPlayers(this.match.id);

            lstPlayers.Items.Clear();

            ListViewItem item;
            foreach (Player player in this.match.players)
            {
                item = new ListViewItem(player.id.ToString());
                item.SubItems.Add(player.name);
                item.SubItems.Add(player.color.ToString());
                lstPlayers.Items.Add(item);
            }
        }

        // Refill the players list with current data from server
        private void btnRefreshListPlayers_Click(object sender, EventArgs e)
        {
            ShowListPlayers();
        }

        // Return
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Panel.getInstance().ChangeForm(this, new Matches());
        }

        // Start match
        // Redirect to board
        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            Game.StartMatch(this.match.user.id, this.match.user.password);
            Panel.getInstance().ChangeForm(this, new Board(this.match));
        }

        // Go to board
        private void btnGoToBoard_Click(object sender, EventArgs e)
        {
            Panel.getInstance().ChangeForm(this, new Board(this.match));
        }

        // Open enter match dialog
        private void btnEnterTheMatch_Click(object sender, EventArgs e)
        {
            EnterMatchDialog enterMatchDialog = new EnterMatchDialog(this, match);
            if (enterMatchDialog.ShowDialog() == DialogResult.OK)
                Console.WriteLine("works");
        }
    }
}
