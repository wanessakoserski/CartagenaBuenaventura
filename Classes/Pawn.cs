using CartagenaBuenaventura.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartagenaBuenaventura.Classes
{
    public class Pawn
    {
        public Player player;
        public Color color;
        public PictureBox img;
        public uint position;
        private int spotIndex;

        public Pawn(Player player)
        {
            this.player = player;
            this.color = (Color)player.color;
            this.position = 0;

            img = new PictureBox();
            img.BackColor = System.Drawing.Color.Transparent;
            img.SizeMode = PictureBoxSizeMode.CenterImage;
            img.Margin = new Padding(0);
            img.Size = new Size(15, 15);

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, img.Width - 2, img.Height - 2);
            Region rg = new Region(gp);
            img.Region = rg;

            if (this.color == Color.Red) { img.Image = Properties.Resources.red; }
            else if (this.color == Color.Green) { img.Image = Properties.Resources.green; }
            else if (this.color == Color.Yellow) { img.Image = Properties.Resources.yellow; }
            else if (this.color == Color.Blue) { img.Image = Properties.Resources.blue; }
            else if (this.color == Color.Brown) { img.Image = Properties.Resources.brown; }
        }

        // Move a pawn PictureBox to the desired location on the Board, meaning that the pawn will be
        // placed in the available position inside the destination tile
        public void Move(Move move, List<Tile> board) 
        {
            this.position = (uint)move.destination;

            Tile origin = board[Convert.ToInt32(move.origin)];
            Tile destination = board[Convert.ToInt32(move.destination)];

            board[Convert.ToInt32(move.origin)].pawnsOnTile.Remove(this);
            board[Convert.ToInt32(move.destination)].pawnsOnTile.Add(this);

            origin.spotAvailable[this.spotIndex] = true;

            Console.WriteLine($"board: tile:{board[destination.position].position}, X:{board[destination.position].location.X}, y:{board[destination.position].location.Y}, ");
            Console.WriteLine($"destination: tile:{destination.position}, X:{destination.location.X}, y:{destination.location.Y}, ");
            
            Console.WriteLine($"pawn {destination.position} -> x:{destination.location.X} y: {destination.location.Y}");

            if (destination.spotAvailable[0])
            {
                img.Location = destination.location;
                if (move.id == 0)
                {
                    Point aux = destination.location;
                    aux.X += 26;
                    img.Location = aux;
                }
                destination.spotAvailable[0] = false;
                this.spotIndex = 0;
            }
            else if (destination.spotAvailable[1])
            {
                Point aux = destination.location;
                aux.X += 15;
                img.Location = aux;

                destination.spotAvailable[1] = false;
                this.spotIndex = 1;
            }
            else
            {
                Point auxLocation = destination.location;
                auxLocation.Y += 15;
                img.Location = auxLocation;

                destination.spotAvailable[2] = false;
                this.spotIndex = 2;
            }
        }
    }
}
