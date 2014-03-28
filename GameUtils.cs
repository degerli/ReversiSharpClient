using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ReversiLab.AI;
using ReversiLab.Play;

namespace ReversiSharpClient
{
    /// <summary>
    /// Before a match make the necessary changes below
    /// </summary>
    internal static class GameUtils
    {
        private const int NoPlayer = 0;
        private const int BlackPlayer = 1;
        private const int WhitePlayer = 2;

        //Game settings
        public const string BaseUrl = "http://stadium2.b3lab.org/rest";
        public const string AuthCode = "qdww4846";
        public const int PlayerColor = WhitePlayer;
        public static readonly ReversiPlayer Player = ReversiPlayerFactory.Create(PlayerType.MiniMax25, WhitePlayer);
    }
}