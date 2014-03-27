using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace ReversiSharpClient
{
    internal class Program
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private readonly GamePlayer _gamePlayer;
        private readonly GameClient _client;

        private Program()
        {
            _gamePlayer = GamePlayer.GetInstance();
            _client = new GameClient(_gamePlayer.BaseUrl);
        }

        private void Connect()
        {
            _autoResetEvent = new AutoResetEvent(false);
            var timerDelegate = new TimerCallback(AttemptToPlay);
            _timer = new Timer(timerDelegate, null, 1000, 1000);
            _autoResetEvent.WaitOne();
        }

        private void AttemptToPlay(Object obj)
        {
            _gamePlayer.Status = _client.GetStatus();

            if (_gamePlayer.Status.Cancelled)
            {
                _timer.Dispose(_autoResetEvent);
            }
            else if (!_gamePlayer.Status.Started)
            {
                _timer.Dispose(_autoResetEvent);
            }
            else if (_gamePlayer.Status.CurrentPlayer == _gamePlayer.Player)
            {
                _client.Move(_gamePlayer.AuthCode, _gamePlayer.Play());
            }
        }

        private static void Main(string[] args)
        {
            var program = new Program();
            program.Connect();
        }
    }
}
