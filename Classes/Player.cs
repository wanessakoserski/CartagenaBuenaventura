using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    public class Player
    {
        public uint id;
        public string name;
        public Color? color;
        public string password;
        public List<Move> moves;
        public List<enums.Symbol?> hand;

        // request all cards on players hand as simbols and their respective quantities
        // from the server, then return a list of them
        public List<enums.Symbol?> ShowHand(uint id, string password) 
        {
            List<string> cards = Jogo.ConsultarMao(Convert.ToInt32(id), password)
                .Replace("\r", "")
                .Split('\n')
                .ToList<string>();

            cards.RemoveAt(hand.Count - 1);

            foreach (string card in cards) 
            {
                string[] aux = card.Split(',');
                enums.Symbol? symbol = null;

                Game.TranslateSymbol(aux[0]);

                for (int i = 0; i < Convert.ToInt32(aux[1]); i++) { hand.Add(symbol); }
            }
            return hand;
        }
    }
}
