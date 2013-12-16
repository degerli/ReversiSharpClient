using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    public class GameStatus
    {
        public List<List<int>> BoardState { get; set; }
        public bool Cancelled { get; set; }
        public int CurrentPlayer { get; set; }
        public bool Started { get; set; }
        public List<string> AvailableMoves { get; set; }
    }
}