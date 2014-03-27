using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    internal static class GameUtils
    {
        private const int NoPlayer = 0;
        private const int BlackPlayer = 1;
        private const int WhitePlayer = 2;

        //GamePlayer settings
        public const string BaseUrl = "http://stadium2.b3lab.org/rest";
        public const string AuthCode = "qdww4846";
        public const int Player = WhitePlayer;
    }
}