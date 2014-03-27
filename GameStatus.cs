using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ReversiLab.Rules;


namespace ReversiSharpClient
{
    public class GameStatus
    {
        public List<List<int>> BoardState { get; set; }
        public bool Cancelled { get; set; }
        public int CurrentPlayer { get; set; }
        public bool Started { get; set; }
        public List<string> AvailableMoves { get; set; }
        
        public Game ToGame()
        {
            Game game = new Game();
            game.CurrentPlayer = CurrentPlayer;
            game.AvailableMoves = AvailableMoves;
            game.BoardState = BoardState;
            return game;
        }
    }

    
}