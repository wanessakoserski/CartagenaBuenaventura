using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    internal class Game
    {
        public void ListMatches()
        {
            string[] matches = Jogo.ListarPartidas("T").Replace("\r", "").Split('\n');
            /*
            foreach (string match in matches)
            {
                if(match != "")
                    Console.WriteLine("> " + match);
            }
            */
        }

        // Receive two strings  name and password as parameters, being name length < 20 and
        // name != from any match name in the server, and password length <= 10. Create a
        // new match and return it
        public Match CreateMatch(string name, string password) 
        {
            Match match = new Match();
            match.name = name;
            match.password = password;
            match.status = enums.MatchStatus.Open;

            match.id = Convert.ToUInt32(Jogo.CriarPartida(name, password));

            return match;
        }
    }
}
