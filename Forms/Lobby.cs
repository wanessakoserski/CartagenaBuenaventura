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
        Player player;
        public Lobby(Match match, Player player = null)
        {
            InitializeComponent();
            this.match = match;
            this.player = player;

            if (this.match.players == null)
                this.match.players = Game.ListPlayers(this.match.id);

            SetListPlayers();

            if (player == null) { btnStartMatch.Enabled = false; }
        }

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

        private void ShowListPlayers()
        {
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

        private void btnRefreshListPlayers_Click(object sender, EventArgs e)
        {
            ShowListPlayers();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Panel.getInstance().ChangeForm(this, new Matches());
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            //Game.StartMatch(player.id, player.password);
            Panel.getInstance().ChangeForm(this, new Board(match));
        }
    }
}
