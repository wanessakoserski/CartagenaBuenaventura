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
            hand = new List<enums.Symbol?>();

            List<string> cards = Jogo.ConsultarMao(Convert.ToInt32(id), password)
                .Replace("\r", "")
                .Split('\n')
                .ToList<string>();
            cards.RemoveAt(cards.Count() - 1);

            foreach (string card in cards) 
            {
                string[] aux = card.Split(',');
                enums.Symbol? symbol = Game.TranslateSymbol(aux[0]);
                Console.WriteLine(symbol.ToString());

                for (int i = 0; i < Convert.ToInt32(aux[1]); i++) { hand.Add(symbol); }
            }

            return hand;
        }

        // Receive one pawn position and the symbol of what card should be played and
        // move the pawn to the next open tile with this symbol
        public void GoFoward(int pawnPosition, enums.Symbol symbol) 
        {
            Jogo.Jogar(Convert.ToInt32(this.id), this.password, pawnPosition, Game.TranslateSymbol(symbol));
        }

        // Receive one pawn position and move it back to the closes tile with at least
        // one pawn and less than three of them
        public void GoBack(int pawnPosition) 
        {
            Jogo.Jogar(Convert.ToInt32(this.id), this.password, pawnPosition);
        }

        // Skip one of the players moves
        public void Skip() 
        {
            Jogo.Jogar(Convert.ToInt32(this.id), this.password);
        }
    }
}
