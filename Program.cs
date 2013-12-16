using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    class Program
    {
        Timer timer;
        GameClient client = new GameClient();
        string authCode = "qlsg3069";
        int player = 2;
        public static AutoResetEvent autoResetEvent
      = new AutoResetEvent(false);

        public void baglan()
        {
            timer = new Timer(new TimerCallback(DoSomething), null, 1000, 1000);
            autoResetEvent.WaitOne();
        }
        private void DoSomething(Object obj)
        {
            Game game = client.status();

            if (game.cancelled)
            {
                timer.Dispose(autoResetEvent);
            }
            else if (!game.started)
            {
                timer.Dispose(autoResetEvent);
            }
            else if (game.currentPlayer == player)
            {

                List<String> availableMoves = game.availableMoves;
                Random random = new Random();
                int randomInt = random.Next(availableMoves.Count);
                String nextMove = availableMoves[randomInt];
                client.move(authCode, nextMove);
            }
        }
        static void Main(string[] args)
        {
            Program cl = new Program();
            cl.baglan();

        }
    }
}
