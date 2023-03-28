using CartagenaBuenaventura.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartagenaBuenaventura.Forms
{
    public partial class Board : Screen
    {
        Match match;
        Player player;
        public Board(Match match, Player player)
        {
            this.match = match;
            this.player = player;
            InitializeComponent();
            SetListTiles();
        }

        private void SetListTiles()
        {
            lstTiles.GridLines = true;
            lstTiles.View = View.Details;
            lstTiles.FullRowSelect = true;
            lstTiles.MultiSelect = false;

            lstTiles.Columns.Add("Posição", 80, HorizontalAlignment.Center);
            lstTiles.Columns.Add("Simbolo", 100, HorizontalAlignment.Center);

            ShowListTiles();
        }

        private void ShowListTiles()
        {
            lstTiles.Items.Clear();

            List<Tile> ListTiles = Game.ShowBoard(match.id);

            ListViewItem item;
            foreach (Tile tile in ListTiles)
            {
                item = new ListViewItem(tile.position.ToString());
                item.SubItems.Add(tile.symbol.ToString());

                lstTiles.Items.Add(item);
            }
        }
    }
}
