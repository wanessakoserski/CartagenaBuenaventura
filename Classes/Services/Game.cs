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

        public static Image getCardImage(string symbol)
        {
            switch (symbol)
            {
                case "F":
                    return Properties.Resources.dager_card;
                case "G":
                    return Properties.Resources.bottle_card;
                case "C":
                    return Properties.Resources.key_card;
                case "P":
                    return Properties.Resources.pistol_card;
                case "T":
                    return Properties.Resources.tricorn_card;
                case "E":
                    return Properties.Resources.skull_card;
                default:
                    return null;
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

        // Creates a list of moves where it can be seen the game history, handling the server return string
        public static List<Move> History(Match match)
        {
            uint? validateValue(string arg)
            {
                if (arg == String.Empty) return null;
                return Convert.ToUInt32(arg);
            }

            List<Move> history = new List<Move>();

            List<string> moves = Jogo.ExibirHistorico(Convert.ToInt32(match.id))
                .Replace("\r", "")
                .Split('\n')
                .ToList();
            moves.RemoveAt(moves.Count() - 1);

            if (match.players == null)
                match.players = ListPlayers(Convert.ToUInt32(match.id));

            uint count = 0;
            foreach(string move in moves)
            {
                string[] aux = move.Split(',');
                // (bug)in somme matches, the last move origin (aux[3]) and destination (aux[4]) are null

                history.Add(new Move
                {
                    id = count++,
                    turn = Convert.ToUInt32(aux[1]),
                    player = SearchPlayer(match.players, Convert.ToUInt32(aux[0])),
                    card = aux[2],
                    origin = validateValue(aux[3]),
                    destination = validateValue(aux[4])
                });
            }

            return history;
        }

        // Receive a list of players and a player id
        // Search for a player with the same id as received and if it is found, it is returned
        public static Player SearchPlayer(List<Player> listPlayers, uint playerId)
        {
            foreach (Player player in listPlayers)
            {
                if (player.id == playerId)
                    return player;
            }

            return null;
        }

        // Search for a match with the same id as received and if it is found, it is returned
        public static Match SearchMatch(Match match)
        {
            List<Match> matches = Game.ListMatches();
            foreach (Match eachMatch in matches)
            {
                if (eachMatch.id == match.id)
                    return match;
            }

            return match;
        }

        // delegate type for callbacks on StatusBoard method
        public delegate List<Tile> StatusBoardCallBack(List<string> statusBoard, List<Tile> board);

        // Receive a match id, and request the board status to the server, then if a callback
        // function is provided, process list<Move> of the board status and in any case, return
        // a boolean value corresponding to if it is the user turn.
        public static bool StatusBoard(Match match,  List<Tile> board = null, StatusBoardCallBack CallBack = null)
        {
            // statusBoard get:
            // first line: status match, player id, current move
            // other lines: tile index, player id, number of pawns inside this tile
            List<string> statusBoard = Jogo.VerificarVez(Convert.ToInt32(match.id))
                .Replace("\r", "")
                .Split('\n')
                .ToList();

            // manipulate List<Tile> board with pawns new positions or not if they stay the same
            if (CallBack != null && board != null) { CallBack(statusBoard, board); }

            string[] aux = statusBoard[0].Split(',');

            //check if its the user turn
            if ( match.user != null && Convert.ToUInt32(aux[1]) == match.user.id) { return true; }
            else { return false; }
        }

        // Delegate type for callbacks responsible for procesing the data of the activity obtained on
        // CheckActivity method
        public delegate void ProcessActivity(Move move);

        // Check if it is the user turn and return true if so
        public static async Task<bool> VerifyTurn(Match match, List<Move> moves = null, ProcessActivity CallBack = null)
        {
            while (!StatusBoard(match))
            {
                // colocar um timer entre as chamadas de statusboard e check activity
                List<Move> activity = CheckActivity(match, moves);
                if (activity != null)
                {
                    // iterate through every move made by other players in the interval of time of 2000 milliseconds 
                    for (int i = 0; i < activity.Count; i++)
                    {
                        CallBack(activity[i]);
                    }
                }

                await Task.Delay(5000);
            }
            return true;
        }

        // Take as parameters the match and a list of moves done till this moment, then check
        // if there is any activity (moves) done by the other players. If any activity is
        // detected return it (i.e. the list of moves done) else return null
        public static List<Move> CheckActivity(Match match, List<Move> moves)
        {
            List<Move> auxMoves = Game.History(match);
            if (moves.Count < auxMoves.Count)
            {
                int movesRecorded = auxMoves.Count - moves.Count;
                return (List<Move>)auxMoves.Skip(auxMoves.Count - movesRecorded);
            }
            return null;
        }

        // Verifying my own turn
        public static async Task<bool> VerifyUserTurn(Match match)
        {
            bool myTurn = false;
            List<string> statusBoard;

            while (!myTurn)
            {
                statusBoard = Jogo.VerificarVez(Convert.ToInt32(match.id))
                .Replace("\r", "")
                .Split('\n')
                .ToList();

                string[] aux = statusBoard[0].Split(',');

                if (match.user != null && Convert.ToUInt32(aux[1]) == match.user.id) { myTurn = true; }

                await Task.Delay(5000);
            }

            return myTurn;
        }

        // Return whose turn it is 
        public static Player VerifyWhoseTurn(Match match)
        {
            Player player;

            List<string> statusBoard = Jogo.VerificarVez(Convert.ToInt32(match.id))
                .Replace("\r", "")
                .Split('\n')
                .ToList();

            string[] aux = statusBoard[0].Split(',');

            player = SearchPlayer(match.players, Convert.ToUInt16(aux[1]));

            return player;
        }

        // Return board situation 
        // position of the pawns, who they belong to, how many pawns are there in that position
        public static List<Locus> BoardSituation(Match match)
        {
            List<Locus> status = new List<Locus>();

            List<string> statusBoard = Jogo.VerificarVez(Convert.ToInt32(match.id))
                .Replace("\r", "")
                .Split('\n')
                .ToList();

            statusBoard.RemoveAt(0);
            statusBoard.RemoveAt(statusBoard.Count() - 1);

            foreach (string line in statusBoard)
            {
                string[] aux = line.Split(',');

                status.Add(new Locus
                {
                    position = Convert.ToInt32(aux[0]),
                    player = SearchPlayer(match.players, Convert.ToUInt32(aux[1])),
                    amount = Convert.ToInt32(aux[2])
                }) ;
            }

            return status;
        }
    }
}
