using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    internal class GameUtils
    {
        public static readonly int NoPlayer = 0;
        public static readonly int BlackPlayer = 1;
        public static readonly int WhitePlayer = 2;

        //Game settings
        public static readonly string BaseUrl = "http://localhost:8080/reversi-stadium/rest";
        public static readonly string AuthCode = "dxbq6474";
        public static readonly int Player = BlackPlayer;
    }
}