using CartagenaBuenaventura.Classes;
using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        List<Tile> board;
        List<Pawn> pawns = new List<Pawn>();

        // Sets match and current player used 
        // Sets tiles and load tiles and hand if there is user
        public Board(Match match)
        {
            this.match = match;
            this.player = this.match.user;

            InitializeComponent();

            pnlBoard.BackColor = System.Drawing.Color.Transparent;

            SetListTiles();

            // Show card list only if you are current player of this match
            if (this.player == null)
                lstHandCards.Visible = false;
            else
                SetListHandCards();

            InitPawns(6);
        }

        // Receives a letter from an object and returns an image of the respective object
        private Image getSymbolImage(string symbol)
        {
            switch (symbol)
            {
                case "F":
                    return Properties.Resources.dager;
                case "G":
                    return Properties.Resources.bottle;
                case "C":
                    return Properties.Resources.key;
                case "P":
                    return Properties.Resources.pistol;
                case "T":
                    return Properties.Resources.tricorn;           
                case "E":
                    return Properties.Resources.skull;     
                default:
                    return null;
            }
        }

        // Draw the board on screen, place all tiles and their corresponding symbols and indexes
        private void DrawBoard()
        {
            board = Game.ShowBoard(match.id);

            Point tileLocation = new Point(0, pnlBoard.Size.Height - 90);
            int drawDirection = 0; // 0: Right and 1: Left

            foreach (Tile tile in board)
            {
                PictureBox picBox = new PictureBox();

                picBox.BackgroundImageLayout = ImageLayout.Stretch;
                picBox.Margin = new Padding(0);
                picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                picBox.Location = tileLocation;
                picBox.Size = (tile.position == 0 || tile.position == board.Count - 1) ? new Size(100, 50) : new Size(50, 50);

                Label tilePosition = new Label();

                tilePosition.Text = $"{tile.position}";
                tilePosition.Location = new Point(0);
                tilePosition.BackColor = System.Drawing.Color.Transparent;
                tilePosition.ForeColor = Color.White;

                picBox.Controls.Add(tilePosition);
                picBox.Image = getSymbolImage(tile.symbol);

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
                    else if (tile.position == board.Count - 1)
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

        // Receive the number of pawns assigned to each player. Initialize all 'Pawn' objects
        // and draw them in the 0th tile position, then call DrawBoard()
        private void InitPawns(uint pawnsPerPlayer) 
        {
            pnlBoard.Controls.Clear();
            Point pawnLocation = new Point(0, pnlBoard.Size.Height - 90);

            for (int i = 0; i < match.players.Count; i++)
            {
                for (int j = 0; j < pawnsPerPlayer; j++)
                {
                    pawns.Add(new Pawn(match.players[i]));
                    pawns[pawns.Count - 1].img.Location = pawnLocation;
                    pnlBoard.Controls.Add(pawns[pawns.Count - 1].img);

                    pawnLocation.X += 15;
                    if ((j + 1) % 2 == 0) 
                    {
                        pawnLocation.X -= 30;
                        pawnLocation.Y += 15; 
                    }
                }
                pawnLocation.X += 30;
                if (i < 2) { pawnLocation.Y = pnlBoard.Size.Height - 90; }
                else
                {
                    if (i == 2) { pawnLocation.X = 0; }
                    pawnLocation.Y = pnlBoard.Size.Height - 45;
                }
            }
            DrawBoard();
        }

        // Receives a letter from an object and returns an image of the respective object
        private Image getCardImage(string symbol)
        {
            switch (symbol)
            {
                case "F":
                    return Properties.Resources.dager_card;
                case "G":
                    return Properties.Resources.bottle_card;
                case "C":
                    return Properties.Resources.key_card;
                case "P":
                    return Properties.Resources.pistol_card;
                case "T":
                    return Properties.Resources.tricorn_card;
                case "E":
                    return Properties.Resources.skull_card;
                default:
                    return null;
            }
        }

        // Sets the information to create the cards list on the screen
        // Call at the same time DrawHandCards
        private void SetListHandCards()
        {
            lstHandCards.MultiSelect = false;
            lstHandCards.FullRowSelect = true;

            imageList.ImageSize = new Size(105, 165);

            DrawHandCards();
        }

        // Clean the current data in list
        // Fill the list hand cards with current data from server and its repective image
        private void DrawHandCards()
        {
            lstHandCards.Clear();
            

            List<string> cards = player.ShowHand(player.id, player.password);

            int index = 0;
            foreach (string card in cards)
            {
                imageList.Images.Add(getCardImage(card));
                lstHandCards.Items.Add(new ListViewItem
                {
                    ImageIndex = index,
                    Text = Game.TranslateSymbol(card),
                    Tag = card
                });
                index++;
            }
            lstHandCards.LargeImageList = imageList;
            lstHandCards.View = View.LargeIcon;
        }

        // Display information on board
        // If there is a player, it is also load hand cards
        private void RefreshList()
        {
            if (this.player != null)
                DrawHandCards();
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
