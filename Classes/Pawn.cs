using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Pawn(Player player, Color color) 
        {
            this.player = player;
            this.color = color;
        }
    }
}
