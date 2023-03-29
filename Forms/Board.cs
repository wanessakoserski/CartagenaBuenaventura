using CartagenaBuenaventura.Classes;
using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace CartagenaBuenaventura.Forms
{
    public partial class Board : Screen
    {
        Match match;
        Player player;
        public Board(Match match)
        {
            this.match = match;
            this.player = this.match.user;
            InitializeComponent();
            SetListTiles();
            RefreshList();
        }

        private void RefreshList()
        {
            ShowListTiles();
            if (this.player != null)
                ShowListHandCards();
            ShowListHistory();
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

        private void ShowListHandCards()
        {
            lstHandCards.Clear();
            lstHandCards.MultiSelect = false;
            lstHandCards.FullRowSelect = true;

            List<enums.Symbol?> listHandCards = player.ShowHand(player.id, player.password);

            ListViewItem item;
            foreach (enums.Symbol card in listHandCards)
            {
                item = new ListViewItem(card.ToString());
                item.Tag = card;
                item.SubItems.Add(card.ToString());
                lstHandCards.Items.Add(item);          
            }
        }

        private void ShowListHistory()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\nVerificar vez\n");
            string vez = Jogo.VerificarVez(Convert.ToInt32(match.id));
            Console.WriteLine(vez);
            Console.WriteLine("\nHistórico\n");
            string history = Jogo.ExibirHistorico(Convert.ToInt32(match.id));
            Console.Write(history);
        }

        private int getPawnPosition()
        {
            return Convert.ToInt32(numChoosePawn.Value);
        }

        private enums.Symbol getCardSelected()
        {
            SelectedListViewItemCollection item = lstHandCards.SelectedItems;
            enums.Symbol symbol = (enums.Symbol) item[0].Tag;

            return symbol;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            player.Skip();
            RefreshList();
        }

        private void btnMoveBack_Click(object sender, EventArgs e)
        {
            player.GoBack(getPawnPosition());
            RefreshList();
        }

        private void btnMoveForward_Click(object sender, EventArgs e)
        {
            player.GoFoward(getPawnPosition(), getCardSelected());
            RefreshList();
        }
    }
}
