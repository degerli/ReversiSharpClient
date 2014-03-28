using System;
using System.Collections.Generic;
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
        
        public ReversiLab.Rules.Game ToGame()
        {
            var game = new ReversiLab.Rules.Game();
            game.CurrentPlayer = CurrentPlayer;
            game.AvailableMoves = AvailableMoves;
            game.BoardState = BoardState;
            return game;
        }
    }

    
}