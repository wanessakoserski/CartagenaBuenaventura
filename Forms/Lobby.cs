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
using CartagenaBuenaventura.Properties;

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

            if(this.match.user == null && player != null)
                this.match.user = player;

            if (this.match.user == null)
                pnlStartMatch.Visible = false;
            else 
                btnEnterTheMatch.Visible = false;

            if (this.match.status == enums.MatchStatus.InProgress || this.match.status == enums.MatchStatus.Close)
                pnlGoToBoard.Enabled = true; 
            else
                pnlGoToBoard.Enabled = false;      

            ShowListPlayers();
        }

        // Clean the current data in list
        // Fill the players list with current data from server
        private void ShowListPlayers()
        {
            this.match.players = Game.ListPlayers(this.match.id);

            dgdPlayers.Rows.Clear();

            foreach (Player player in this.match.players)
            {
                int index = dgdPlayers.Rows.Add();
                dgdPlayers.Rows[index].Cells[0].Value = player.name;
                dgdPlayers.Rows[index].DefaultCellStyle.Font = new Font("OCR A Extended",
                                                                       14,
                                                                       FontStyle.Regular,
                                                                       GraphicsUnit.Pixel);

                dgdPlayers.Rows[index].DefaultCellStyle.BackColor = (Color) player.color;

                if ((Color)player.color == Color.Yellow)
                    dgdPlayers.Rows[index].DefaultCellStyle.BackColor = Color.Goldenrod;
            }

            dgdPlayers.ClearSelection();
        }

        // Refill the players list with current data from server
        private void pnlRefreshListPlayers_Click(object sender, EventArgs e)
        {
            ShowListPlayers();
        }

        // Start match if it is still opened
        // Redirect to board
        private void pnlStartMatch_Click(object sender, EventArgs e)
        { 
            if (this.match.status == enums.MatchStatus.Open)
                Game.StartMatch(this.match.user.id, this.match.user.password);

            Panel.getInstance().ChangeForm(this, new Board(this.match));
        }

        // Go to board
        private void pnlGoToBoard_Click(object sender, EventArgs e)
        {
            Panel.getInstance().ChangeForm(this, new Board(this.match));
        }

        // Open enter match dialog
        private void btnEnterTheMatch_Click(object sender, EventArgs e)
        {
            using(EnterMatchDialog enterMatchDialog = new EnterMatchDialog(this, match))
            {
                if (enterMatchDialog.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("works");
                    btnEnterTheMatch.Visible = false;
                    ShowListPlayers();
                    pnlStartMatch.Enabled = true;
                    pnlStartMatch.Visible = true;
                    this.match.user = enterMatchDialog.getPlayer();
                }
            }  
        }

        // Return
        private void pnlGoBackMatches_Click(object sender, EventArgs e)
        {
            Panel.getInstance().ChangeForm(this, new Matches());
        }


        /* Appearance */

        private void pnlGoBackMatches_MouseEnter(object sender, EventArgs e)
        {
            pnlGoBackMatches.BackgroundImage = Resources.back_arrow;
        }

        private void pnlGoBackMatches_MouseLeave(object sender, EventArgs e)
        {
            pnlGoBackMatches.BackgroundImage = Resources.go_back_arrow;
        }
    }
}
