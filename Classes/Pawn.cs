using CartagenaBuenaventura.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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

        public Pawn(Player player)
        {
            this.player = player;
            this.color = (Color)player.color;

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
    }
}
