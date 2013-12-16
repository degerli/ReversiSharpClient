using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    /// <summary>
    /// A Reversi Player that selects an available move randomly without any logic.
    /// </summary>
    internal class RandomReversiPlayer : IReversiPlayer
    {
        public string Play(GameStatus gameStatus)
        {
            List<String> availableMoves = gameStatus.AvailableMoves;
            var random = new Random();
            int randomInt = random.Next(availableMoves.Count);
            string nextMove = availableMoves[randomInt];
            return nextMove;
        }
    }
}