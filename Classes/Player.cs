using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    internal class Player
    {
        public uint id;
        public string name;
        public Color color;
        public string password;
        public List<Move> moves;
        public List<Card> hand;

    }
}
