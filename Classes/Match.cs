using CartagenaBuenaventura.enums;
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
        public enums.MatchStatus status;
        public string password;
        public List<Player> players;

        public Match(uint id, string name, DateTime creationDate, MatchStatus status)
        {
            this.id = id;
            this.name = name;
            this.creationDate = creationDate;
            this.status = status;
        }
    }
}
