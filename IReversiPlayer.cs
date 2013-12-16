using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    /// <summary>
    /// A Reversi player interface with just one method "string Play(GameStatus gameStatus)"
    /// </summary>
    internal interface IReversiPlayer
    {
        string Play(GameStatus gameStatus);
    }
}