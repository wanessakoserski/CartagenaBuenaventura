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

        // Sets match and current player used 
        // Sets tiles and load tiles and hand if there is user
        public Board(Match match)
        {
            this.match = match;
            this.player = this.match.user;
            InitializeComponent();
            SetListTiles();
            RefreshList();
        }

        // Display information on board
        // If there is a player, it is also load hand cards
        private void RefreshList()
        {
            ShowListTiles();
            if (this.player != null)
                ShowListHandCards();
            ShowListHistory();
        }

        // Sets the information to create the tiles list on the screen
        private void SetListTiles()
        {
            lstTiles.GridLines = true;
            lstTiles.View = View.Details;
            lstTiles.FullRowSelect = true;
            lstTiles.MultiSelect = false;

            lstTiles.Columns.Add("Posição", 80, HorizontalAlignment.Center);
            lstTiles.Columns.Add("Simbolo", 100, HorizontalAlignment.Center);
        }

        // Clean the current data in list
        // Fill the list tiles with current data from server
        private void ShowListTiles()
        {
            lstTiles.Items.Clear(); 

            List<Tile> ListTiles = Game.ShowBoard(match.id);

            ListViewItem item;
            foreach (Tile tile in ListTiles)
            {
                item = new ListViewItem(tile.position.ToString());
                item.SubItems.Add(Game.TranslateSymbol(tile.symbol));

                lstTiles.Items.Add(item);
            }
        }

        // Clean the current data in list
        // Fill the list hand cards with current data from server
        private void ShowListHandCards()
        {
            lstHandCards.Clear();
            lstHandCards.MultiSelect = false;
            lstHandCards.FullRowSelect = true;

            List<string> listHandCards = player.ShowHand(player.id, player.password);

            ListViewItem item;
            foreach (string card in listHandCards)
            {
                item = new ListViewItem(card.ToString());
                item.Tag = card;
                item.SubItems.Add(Game.TranslateSymbol(card));
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

        // Get current number on numChoosePawn
        private int getPawnPosition()
        {
            return Convert.ToInt32(numChoosePawn.Value);
        }

        // Get current clicked card on hand cards list
        private string getCardSelected()
        {
            SelectedListViewItemCollection item = lstHandCards.SelectedItems;
                string symbol = (string) item[0].Tag;

            return symbol;
        }

        // Use skip function and renew lists
        private void btnSkip_Click(object sender, EventArgs e)
        {
            player.Skip();
            RefreshList();
        }

        // Use go back function and renew lists
        private void btnMoveBack_Click(object sender, EventArgs e)
        {
            player.GoBack(getPawnPosition());
            RefreshList();
        }

        // Use move forward function and renew lists
        private void btnMoveForward_Click(object sender, EventArgs e)
        {
            player.GoFoward(getPawnPosition(), getCardSelected());
            RefreshList();
        }
    }
}
