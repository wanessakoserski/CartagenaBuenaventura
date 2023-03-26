using CartagenaServer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    internal class Game
    {
        // Creates a list of matches, handling the server return string
        public List<Match> ListMatches(string filter = "T")
        {
            List<Match> ListMatches = new List<Match>();

            List<string> matches = Jogo.ListarPartidas(filter)
                .Replace("\r", "")
                .Split('\n')
                .ToList();
            matches.RemoveAt(matches.Count() - 1);
            
            string[] info = new string[5];
            foreach (string match in matches)
            {
                info = match.Split(',');           
                ListMatches.Add(new Match(
                    Convert.ToUInt32(info[0]), 
                    info[1],
                    Convert.ToDateTime(info[2]),
                    info[3] == "A" ? enums.MatchStatus.Open : info[3] == "J" ? enums.MatchStatus.InProgress : enums.MatchStatus.Close));
            }

            return ListMatches;        
        }

        // Receive two strings  name and password as parameters, being name length < 20 and
        // name != from any match name in the server, and password length <= 10. Create a
        // new match and return it
        public Match CreateMatch(string name, string password) 
        {
            Match match = new Match
            {
                id = Convert.ToUInt32(Jogo.CriarPartida(name, password)),
                name = name,
                password = password,
                status = enums.MatchStatus.Open
            };
            
            return match;
        }
    }
}
