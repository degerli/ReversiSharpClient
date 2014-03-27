using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReversiLab.AI;
using ReversiLab.Play;


namespace ReversiSharpClient
{
    public class GamePlayer
    {
        //Singleton instance
        private static GamePlayer _gamePlayer = null;

        // AI 
        private readonly ReversiPlayer _reversiPlayer;
        public string AuthCode { get; private set; }
        public string BaseUrl { get; private set; }
        public int Player { get; private set; }

        public GameStatus Status { get; set; }

        public static GamePlayer GetInstance()
        {
            if (_gamePlayer != null)
            {
                return _gamePlayer;
            }
            _gamePlayer = new GamePlayer();
            return _gamePlayer;
        }

        private GamePlayer()
        {
            //These will be moved to properties file
            _reversiPlayer = ReversiPlayerFactory.Create(PlayerType.DynamicMinmax, GameUtils.Player);
            Player = GameUtils.Player;
            AuthCode = GameUtils.AuthCode;
            BaseUrl = GameUtils.BaseUrl;
        }

        public string Play()
        {
            return _reversiPlayer.GetNextMove(Status.ToGame());
        }
    }
}