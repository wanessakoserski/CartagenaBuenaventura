﻿using CartagenaBuenaventura.Classes;
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
        private Match match;
        private Player player;
        private Robot robot;
        private Timer timer;
        private List<Tile> board;
        private List<Pawn> pawns = new List<Pawn>();
        private List<Move> moves = new List<Move>();

        // Sets match and current player used 
        // Sets tiles and load tiles and hand if there is user
        public Board(Match match)
        {
            this.match = match;

            // ensure data is up to date
            this.match.players = Game.ListPlayers(this.match.id);

            this.player = this.match.user;

            InitializeComponent();
            
            pnlBoard.BackColor = System.Drawing.Color.Transparent;

            InitPawns(6);
            timer = new Timer();
            timer.Interval = 10 * 1000;

            // Show card list only if you are current player of this match
            // Set also the automation
            if (this.player == null)
                pnlBackgroundListHandCards.Visible = false;
            else
            {
                SetListHandCards();
                this.robot = new Robot(this.match, board);
                timer.Tick += RefreshList;                
            }

            timer.Tick += RefreshBoard;
            timer.Start();
            RefreshPirateTurn();
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

            for (int i = 0; i < match.players.Count; i++)
            {
                for (int j = 0; j < pawnsPerPlayer; j++)
                {
                    pawns.Add(new Pawn(match.players[i]));
                    pawns[pawns.Count - 1].img.Location = PawnLocation(0, (j + (i * (int)pawnsPerPlayer)), (int)pawnsPerPlayer);
                    pnlBoard.Controls.Add(pawns[pawns.Count - 1].img);
                }
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
        
        // receive the tile position and the Nth pawn (beging at 0) inside the tile, then return the location (cordinates)
        // of this pawn
        private Point PawnLocation(int tilePosition, int nthPawn, int pawnsPerPlayer)
        {
            int x, y;
            if (tilePosition == 0)
            {
                x = ((nthPawn / pawnsPerPlayer) % 2 == 0) ? 0 : 35;
                y = (((nthPawn / pawnsPerPlayer) / 2) * 45) + 15;
            }
            else
            {
                int collum = (tilePosition % 5 == 0) ? (tilePosition / 5) : (tilePosition / 5) + 1;
                int aux;

                if (collum % 2 == 0)
                {
                    aux = ((tilePosition % 5 == 0) ? 4 : (tilePosition % 5) - 1);
                }
                else
                {
                    aux = (5 - ((tilePosition % 5 == 0) ? 5 : tilePosition % 5));
                }

                x = (pnlBoard.Size.Width / 10 * 2) + ((collum - 1) * (pnlBoard.Size.Width / 10));
                y = pnlBoard.Size.Height / 5 * aux;
            }

            Point location = new Point(x, y);

            location.X = ((nthPawn % pawnsPerPlayer) % 2 == 0) ? location.X : location.X + 15;
            location.Y = location.Y + ((nthPawn % pawnsPerPlayer) / 2) * 15;

            // margin
            location.Offset(12, 12);

            return location;
        }

        // Drawn all pawns on board using the board status information provided by Game.StatusBoard() method
        // (is passed as a callback to Game.StatusBoard())
        public List<Tile> DrawPawns(List<string> statusBoard, List<Tile> board)
        {
            List<Pawn> auxPawns = new List<Pawn>(pawns);
            Dictionary<int, int> pawnsOnTile = new Dictionary<int, int>();

            for (int i = 1; i < statusBoard.Count; i++)
            {
                /**
                 * aux[0] -> tile
                 * aux[1] -> player
                 * aux[2] -> number of pawns (from the player) on tile
                 */
                String[] aux = statusBoard[i].Split(',');

                int tileNum = int.Parse(aux[0]);
                int numPawns = int.Parse(aux[2]);

                if (!pawnsOnTile.ContainsKey(tileNum))
                {
                    pawnsOnTile.Add(tileNum, 0);
                }

                List<Pawn> playerPawns = auxPawns.FindAll(p => p.player.id == uint.Parse(aux[1]));

                for (int j = 0; j < numPawns; j++)
                {
                    playerPawns[j].img.Location = PawnLocation(tileNum, pawnsOnTile[tileNum]++, 6);
                    auxPawns.Remove(playerPawns[j]);
                }
            }

            return board;
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
            imageList.Images.Clear();

            List<string> cards = player.ShowHand(player.id, player.password);

            int index = 0;
            foreach (string card in cards)
            {
                Console.WriteLine("Card: " + card);
                imageList.Images.Add(Game.getCardImage(card));
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

        // Get information to show whose turn it is
        private void RefreshPirateTurn()
        {
            Player playerTurn = Game.VerifyWhoseTurn(this.match);
            lblPirateName.Text = playerTurn.name;

            Color color = (Color) playerTurn.color;
            switch (color.Name)
            {
                case "Red":
                    pnlPirateImage.BackgroundImage = Properties.Resources.PirateRed;
                    break;
                case "Green":
                    pnlPirateImage.BackgroundImage = Properties.Resources.PirateGreen;
                    break;
                case "Yellow":
                    pnlPirateImage.BackgroundImage = Properties.Resources.PirateYellow;
                    break;
                case "Blue":
                    pnlPirateImage.BackgroundImage = Properties.Resources.PirateBlue;
                    break;
                case "Brown":
                    pnlPirateImage.BackgroundImage = Properties.Resources.PirateBrown;
                    break;
                default:
                    break;
            }
        }

        // verify if there is a winner 
        // in case of a winner, it stops the timer and the robot and declare the winner
        private void VerifyWinner()
        {
            (bool isThereAWinner, Player winner) verifyGame = Game.VerifyWinner(this.match);
            if (verifyGame.isThereAWinner)
            {
                this.timer.Stop();
                this.timer = null;
                this.robot = null;

                lblPirateName.Text = "Winner: " + verifyGame.winner.name;
                pnlPirateImage.BackgroundImage = Properties.Resources.winner;
            }
        }

        // Display information on board during a game
        private async void RefreshBoard(object sender, EventArgs e)
        {
            Game.StatusBoard(match, board, DrawPawns);
            RefreshPirateTurn();
            VerifyWinner();
            Console.WriteLine("board");
            await Task.Delay(5 * 1000);
        }

        // Display information on board during a game
        private async void RefreshList(object sender, EventArgs e)
        {
            bool turnFinish = false;
            try
            {
                turnFinish = await robot.Verifying();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (turnFinish)
            {
                DrawHandCards();
                Console.WriteLine("mão impressa");
            }

            await Task.Delay(5 * 1000);
        }


        // as soon as redirected, the timer and robot is stopped
        private void pnlGoBackHome_Click(object sender, EventArgs e)
        {
            if (this.timer != null) { this.timer.Stop(); }
            this.timer = null;
            this.robot = null;
            
            Panel.getInstance().ChangeForm(this, new Home());
        }
    }
}
