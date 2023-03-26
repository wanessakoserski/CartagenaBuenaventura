using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    internal class Match
    {
        public uint id;
        public string name;
        public DateTime creationDate;
        public Status status;
        public string password;
        public List<Player> players;
    }

    public enum Status 
    {
        Open,
        Close,
        InProgress
    }
}
