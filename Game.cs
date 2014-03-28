using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ReversiLab.AI;
using ReversiLab.Play;


namespace ReversiSharpClient
{
    public class Game
    {
        //Singleton; there must be only one game at a time!
        private static Game _game;
        public string AuthCode { get; private set; }
        public string BaseUrl { get; private set; }
        public int Player { get; private set; }
        public GameStatus Status { get; set; }
        //The strategy which chooses our next move by some AI method
        private readonly ReversiPlayer _reversiPlayer;

        private Game()
        {
            _reversiPlayer = GameUtils.Player;  //AI
            Player = GameUtils.PlayerColor;     //Color: Black or White
            AuthCode = GameUtils.AuthCode;      //Authentication code
            BaseUrl = GameUtils.BaseUrl;        //URL of the server
        }

        //~ ----------------------------------------------------------------------------------------------------------------
        public static Game GetInstance()
        {
            if (_game != null)
            {
                return _game;
            }
            _game = new Game();
            return _game;
        }
        //~ ----------------------------------------------------------------------------------------------------------------
        public string GetNextMove()
        {
            return _reversiPlayer.GetNextMove(Status.ToGame());
        }
    }
}