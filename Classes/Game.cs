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
    }
}
