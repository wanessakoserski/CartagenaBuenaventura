using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartagenaBuenaventura.Classes
{
    public class Tile
    {
        public string symbol;
        public int position;
        public Point location;
        public bool[] spotAvailable = new[] { true, true, true };
    }
}
