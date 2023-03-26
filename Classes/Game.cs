using CartagenaServer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    internal static class Game
    {
        // Creates a list of matches, handling the server return string
        public static List<Match> ListMatches(string filter = "T")
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
                    info[3] == "A" ? enums.MatchStatus.Open : info[3] == "J" ? enums.MatchStatus.InProgress : enums.MatchStatus.Close
                    ));
            }

            return ListMatches;        
        }

        // Receive one match Id and return a list of all Players inside the match for the corresponding id
        public static List<Player> ListPlayers(uint matchId) 
        {
            List<Player> iteration(List<string> lst, int length, List<Player> plyrs)
            {
                if (length == 0) return plyrs;
                var content = lst[length - 1].Split(',');
                Player player = new Player
                {
                    id = Convert.ToUInt32(content[0]),
                    name = content[1],
                    //color = content[2]
                };
                plyrs.Add(player);
                return iteration(lst, length - 1, plyrs);
            }

            List<Player> players = new List<Player>();
            List<string> aux = Jogo.ListarJogadores(Convert.ToInt32(matchId))
                .Replace("\r", "")
                .Split('\n')
                .ToList<string>();

            aux.RemoveAt(aux.Count - 1);

            return iteration(aux, aux.Count, new List<Player>());
        }

        // Receive two strings  name and password as parameters, being name length < 20 and
        // name != from any match name in the server, and password length <= 10. Create a
        // new match and return it
        public static Match CreateMatch(string name, string password) 
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
