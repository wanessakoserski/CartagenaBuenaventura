using CartagenaBuenaventura.enums;
using CartagenaServer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            string[] aux = new string[5];
            foreach (string match in matches)
            {
                aux = match.Split(',');
                ListMatches.Add(new Match
                {
                    id = Convert.ToUInt32(aux[0]),
                    name = aux[1],
                    creationDate = DateTime.ParseExact(aux[2], "d/M/yyyy", CultureInfo.InvariantCulture),
                    status = aux[3] == "A" ? enums.MatchStatus.Open : aux[3] == "J" ? enums.MatchStatus.InProgress : enums.MatchStatus.Close
                });                   
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
                    color = TranslateColor(content[2])
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

        // receive a color as a string in Pt-Br and return it as argb color format
        private static Color? TranslateColor(string color)
        {
            switch (color)
            {
                case "Vermelho":
                    return Color.Red;
                case "Verde":
                    return Color.Green;
                case "Amarelo":
                    return Color.Yellow;
                case "Azul":
                    return Color.Blue;
                case "Marrom":
                    return Color.Brown;
                default:
                    return null;
            }
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

        // Request to the server the ingress of a new player to the match corresponding to the match Id
        // passed as a parameter and return the Player (with its password)
        public static Player EnterMatch(uint matchId, string playerName, string matchPassword) 
        {
            string[] aux = Jogo.EntrarPartida(Convert.ToInt32(matchId), playerName, matchPassword)
                .Replace("\r\n", "")
                .Split(',');

            Player player = new Player
            {
                id = Convert.ToUInt32(aux[0]),
                name = playerName,
                password = aux[1],
                color = TranslateColor(aux[2])
            };

            return player;
        }

        // Receive the letter of a symbol and return the whole name
        public static string TranslateSymbol(string symbol)
        {
            switch (symbol)
            {
                case "F":
                    return "Adaga";
                case "G":
                    return "Garrafa";
                case "C":
                    return "Chave";
                case "P":
                    return "Pistola";
                case "T":
                    return "Tricornio";
                case "E":
                    return "Caveira";
                default:
                    return "";
            }
        }

        // Creates a list of tiles where it can be seen the board, handling the server return string
        public static List<Tile> ShowBoard(uint matchId)
        {
            List<Tile> ListTiles = new List<Tile>();

            List<string> tiles = Jogo.ExibirTabuleiro(Convert.ToInt32(matchId))
                .Replace("\r", "")
                .Split('\n')
                .ToList();
            tiles.RemoveAt(tiles.Count() - 1);

            string[] aux = new string[2];
            foreach (string tile in tiles)
            {
                aux = tile.Split(',');
                ListTiles.Add(new Tile
                {
                    position = Convert.ToInt32(aux[0]),
                    symbol = aux[1]
                });
            }

            return ListTiles;
        }

        // receive the id and password of the player Starting the game and
        // return the Id of which one of the players is going to start playing
        public static uint StartMatch(uint playerId, string playerPassword) 
        {
            return Convert.ToUInt32(Jogo.IniciarPartida(Convert.ToInt32(playerId), playerPassword));
        }
    }
}
