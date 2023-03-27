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
        public Board(Match match)
        {
            InitializeComponent();
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
