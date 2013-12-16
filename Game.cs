using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    class Game
    {
        public List<List<int>> boardState { get; set; }
        public bool cancelled { get; set; }
        public int currentPlayer { get; set; }
        public bool started { get; set; }
        public List<string> availableMoves { get; set; }
    }
}
