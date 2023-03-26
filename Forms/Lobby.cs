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
        public Lobby(Match match)
        {
            InitializeComponent();
            this.match = match;

            if (this.match.players == null)
                this.match.players = Game.ListPlayers(this.match.id);

            SetListMatches();
        }

        private void SetListMatches()
        {
            lstPlayers.GridLines = true;
            lstPlayers.View = View.Details;
            lstPlayers.FullRowSelect = true;

            lstPlayers.Columns.Add("Id", 50, HorizontalAlignment.Center);
            lstPlayers.Columns.Add("Nome", 100, HorizontalAlignment.Center);
            lstPlayers.Columns.Add("Cor", 100, HorizontalAlignment.Center);
        }
    }
}
