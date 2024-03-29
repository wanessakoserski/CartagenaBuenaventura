﻿using CartagenaServer;
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
        public List<string> hand;

        // request all cards on players hand as simbols and their respective quantities
        // from the server, then return a list of them
        public List<string> ShowHand(uint id, string password) 
        {
            hand = new List<string>();

            List<string> cards = Jogo.ConsultarMao(Convert.ToInt32(id), password)
                .Replace("\r", "")
                .Split('\n')
                .ToList<string>();
            cards.RemoveAt(cards.Count() - 1);

            foreach (string card in cards) 
            {
                string[] aux = card.Split(',');
                string symbol = aux[0];

                for (int i = 0; i < Convert.ToInt32(aux[1]); i++) { hand.Add(symbol); }
            }

            return hand;
        }

        // return the hand cards with their symbol and how many there are of it
        public List<(string, int)> ShowHandCounting()
        {
            List<(string, int)> h = new List<(string, int)>();

            List<string> cards = Jogo.ConsultarMao(Convert.ToInt32(id), password)
                .Replace("\r", "")
                .Split('\n')
                .ToList<string>();
            cards.RemoveAt(cards.Count() - 1);

            foreach (string card in cards)
            {
                string[] aux = card.Split(',');

                h.Add((aux[0], Convert.ToInt32(aux[1])));
            }

            return h;
        }

        public int HandCardCount()
        {
            int count = 0;

            List<string> cards = Jogo.ConsultarMao(Convert.ToInt32(id), password)
                .Replace("\r", "")
                .Split('\n')
                .ToList<string>();
            cards.RemoveAt(cards.Count() - 1);

            foreach (string card in cards)
            {
                count++;
            }

            return count;
        }

        // Receive one pawn position and the symbol of what card should be played and
        // move the pawn to the next open tile with this symbol
        public void GoFoward(int pawnPosition, string symbol) 
        {
            Jogo.Jogar(Convert.ToInt32(this.id), this.password, pawnPosition, symbol);
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
