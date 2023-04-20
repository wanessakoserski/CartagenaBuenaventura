using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    public class Move
    {
        public uint id;
        public uint turn;
        public Player player;
        public string card;
        public uint origin;
        public uint destination;
    }
}
