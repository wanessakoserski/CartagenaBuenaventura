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
        List<Move> moves = new List<Move>();

        // Sets match and current player used 
        // Sets tiles and load tiles and hand if there is user
        public Board(Match match)
        {
            this.match = match;
            this.player = this.match.user;

            InitializeComponent();

            pnlBoard.BackColor = System.Drawing.Color.Transparent;

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
            if (board == null) { board = Game.ShowBoard(match.id); }

            Point tileLocation = new Point(0, 0);
            int drawDirection = 0; // 0: Upward and 1: Down

            foreach (Tile tile in board)
            {
                PictureBox picBox = new PictureBox();

                picBox.Margin = new Padding(0);
                picBox.Padding = new Padding(0);
                picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                picBox.Location = tileLocation;

                tile.location = tileLocation;

                Label tilePosition = new Label();

                tilePosition.Text = $"{tile.position}";
                tilePosition.Location = new Point(0);
                tilePosition.BackColor = System.Drawing.Color.Transparent;
                tilePosition.ForeColor = Color.White;

                picBox.Controls.Add(tilePosition);

                Size tileDimensions = new Size(pnlBoard.Size.Width / 10, pnlBoard.Size.Height / 5);

                if (tile.position == 0)
                {
                    picBox.Size = new Size(tileDimensions.Width * 2, pnlBoard.Height);
                    tileLocation.X = (pnlBoard.Size.Width / 10) * 2;
                    tileLocation.Y = 4 * pnlBoard.Size.Height / 5;    // the height of where the first tile should be drawned
                }
                else if (tile.position == board.Count - 1)
                {
                    picBox.Size = new Size(tileDimensions.Width, tileDimensions.Height * 2);

                    Image imgBoat = Properties.Resources.boat;
                    imgBoat.RotateFlip(RotateFlipType.Rotate270FlipNone);

                    picBox.Image = imgBoat;
                }
                else
                {
                    picBox.BackgroundImageLayout = ImageLayout.Stretch;
                    picBox.Size = tileDimensions;
                    picBox.Image = getSymbolImage(tile.symbol);

                    //Console.WriteLine($"tile: {tile.position} symbol: {tile.symbol}");

                    Image imgTileCorner = Properties.Resources.tile_corner;

                    if ((tile.position) % 5 == 0)
                    {
                        if (tileLocation.Y == 0)
                        {
                            imgTileCorner.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        }
                        else 
                        {
                            imgTileCorner.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        }

                        picBox.BackgroundImage = imgTileCorner;
                        tileLocation.X += pnlBoard.Size.Width / 10;
                    }
                    else if ((tile.position - 1) % 5 == 0 && tile.position != 1)
                    {
                        if (tileLocation.Y == 0)
                        {
                            imgTileCorner.RotateFlip(RotateFlipType.Rotate180FlipX);
                            tileLocation.Y += pnlBoard.Size.Height / 5;
                            drawDirection = 1;
                        }
                        else
                        {
                            tileLocation.Y -= pnlBoard.Size.Height / 5;
                            drawDirection = 0;
                        }

                        picBox.BackgroundImage = imgTileCorner;
                    }
                    else
                    {
                        picBox.BackgroundImage = Properties.Resources.tile_vertical;

                        if (drawDirection == 0)
                        {
                            tileLocation.Y -= pnlBoard.Size.Height / 5;
                        }
                        else
                        {
                            tileLocation.Y += pnlBoard.Size.Height / 5;
                        }
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
            Point pawnLocation = new Point(0, 15);

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

                pawnLocation.X += 35;
                pawnLocation.Y = (((i + 1) / 2) * 45) + 15;

                if ((i + 1) % 2 == 0) { pawnLocation.X = 0; }
            }

            DrawBoard();
        }

        // Draw the pawn movement of the move passed as parameter or the last move received from Game.History() method
        public void PawnMovement(Move move = null)
        {
            if (move == null) 
            { 
                moves = Game.History(match);
                move = moves.Last();
            }

            if (move.origin != null) 
            {
                // if the move was not "SKIP" 
                Pawn auxPawn = pawns.Find(p => { return p.player == move.player && p.position == move.origin; });
                if (auxPawn != null) { auxPawn.Move(move, board); }

                DrawBoard();
            }
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
        private async void RefreshList()
        {
            if (this.player != null) { DrawHandCards(); }

            PawnMovement();
            await Game.VerifyTurn(match, moves, PawnMovement);
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
            try
            {
                player.GoFoward(getPawnPosition(), getCardSelected());
                RefreshList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
