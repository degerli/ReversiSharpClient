using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    internal class Program
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private readonly Game _game;
        private readonly GameClient _client;

        private Program()
        {
            _game = Game.GetInstance();
            _client = new GameClient(_game.BaseUrl);
        }

        public void Connect()
        {
            _autoResetEvent = new AutoResetEvent(false);
            var timerDelegate = new TimerCallback(AttemptToPlay);
            _timer = new Timer(timerDelegate, null, 1000, 1000);
            _autoResetEvent.WaitOne();
        }

        private void AttemptToPlay(Object obj)
        {
            _game.Status = _client.GetStatus();

            if (_game.Status.Cancelled)
            {
                _timer.Dispose(_autoResetEvent);
            }
            else if (!_game.Status.Started)
            {
                _timer.Dispose(_autoResetEvent);
            }
            else if (_game.Status.CurrentPlayer == _game.Player)
            {
                _client.Move(_game.AuthCode, _game.Play());
            }
        }

        private static void Main(string[] args)
        {
            var program = new Program();
            program.Connect();
        }
    }
}