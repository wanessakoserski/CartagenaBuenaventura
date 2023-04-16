using CartagenaBuenaventura.Classes;
using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            DrawBoard();
        }

        // Draw the board on screen, place all tiles and their corresponding symbols and indexes
        private void DrawBoard()
        {
            List<Tile> listTiles = Game.ShowBoard(match.id);

            Point tileLocation = new Point(0, pnlBoard.Size.Height - 50);
            int drawDirection = 0; // 0: Right and 1: Left

            foreach (Tile tile in listTiles)
            {
                PictureBox picBox = new PictureBox();

                picBox.BackgroundImageLayout = ImageLayout.Stretch;
                picBox.Margin = new Padding(0);
                picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                picBox.Location = tileLocation;
                picBox.Size = (tile.position == 0 || tile.position == listTiles.Count - 1) ? new Size(100, 50) : new Size(50, 50);

                Label tilePosition = new Label();

                tilePosition.Text = $"{tile.position}";
                tilePosition.Location = new Point(0);
                tilePosition.BackColor = System.Drawing.Color.Transparent;
                tilePosition.ForeColor = Color.White;

                picBox.Controls.Add(tilePosition);

                switch (tile.symbol)
                {
                    case "F":
                        picBox.Image = Properties.Resources.dager;
                        break;
                    case "G":
                        picBox.Image = Properties.Resources.bottle;
                        break;
                    case "C":
                        picBox.Image = Properties.Resources.key;
                        break;
                    case "P":
                        picBox.Image = Properties.Resources.pistol;
                        break;
                    case "T":
                        picBox.Image = Properties.Resources.tricorn;
                        break;
                    case "E":
                        picBox.Image = Properties.Resources.skull;
                        break;
                    default:
                        break;

                }

                Image imgTileCorner = Properties.Resources.tile_corner;

                if ((tile.position - 3) % 5 == 0)
                {
                    if (tileLocation.X == 0)
                    {
                        imgTileCorner.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        picBox.BackgroundImage = imgTileCorner;
                    }

                    picBox.BackgroundImage = imgTileCorner;
                    tileLocation.Y -= 50;
                }
                else if ((tile.position - 4) % 5 == 0)
                {
                    if (tileLocation.X == 0)
                    {
                        imgTileCorner.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        tileLocation.X += 50;
                        drawDirection = 0;
                    }
                    else
                    {
                        imgTileCorner.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        tileLocation.X -= 50;
                        drawDirection = 1;
                    }

                    picBox.BackgroundImage = imgTileCorner;
                }
                else
                {
                    if (tile.position == 0)
                    {
                        tileLocation.X = 50;
                    }
                    else if (tile.position == listTiles.Count - 1)
                    {
                        tileLocation.X -= 50;
                        picBox.Location = tileLocation;
                        picBox.Image = Properties.Resources.boat;
                    }
                    else 
                    {
                        picBox.BackgroundImage = Properties.Resources.tile_horizontal;
                    }

                    if (drawDirection == 0)
                    {
                        tileLocation.X += 50;
                    }
                    else 
                    {
                        tileLocation.X -= 50;
                    }
                }

                pnlBoard.Controls.Add(picBox);
            }
        }

        // Display information on board
        // If there is a player, it is also load hand cards
        private void RefreshList()
        {
            if (this.player != null)
                ShowListHandCards();
        }

        // Sets the information to create the tiles list on the screen
        // Call at the same time ShowListTiles
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

        // Clean the current data in list
        // Fill the list tiles with current data from server
        private void ShowListTiles()
        {
            List<Tile> ListTiles = Game.ShowBoard(match.id);

            lstTiles.Items.Clear();

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
