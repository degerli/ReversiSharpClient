using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    public class Game
    {
        //Singleton instance
        private static Game _game = null;

        // AI 
        private readonly IReversiPlayer _player;
        public string AuthCode { get; private set; }
        public string BaseUrl { get; private set; }
        public int Player { get; private set; }

        public GameStatus Status { get; set; }

        public static Game GetInstance()
        {
            if (_game != null)
            {
                return _game;
            }
            _game = new Game();
            return _game;
        }

        private Game()
        {
            //These will be moved to properties file
            _player = new RandomReversiPlayer();
            Player = GameUtils.Player;
            AuthCode = GameUtils.AuthCode;
            BaseUrl = GameUtils.BaseUrl;
        }

        public string Play()
        {
            return _player.Play(Status);
        }
    }
}