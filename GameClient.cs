using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    class GameClient
    {
        private RestClient _restClient = new RestClient(){ BaseUrl = "http://localhost:8080/reversi-stadium/rest" };
        

        public Game cancel(string cancellationCode)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/cancel/{cancellationCode}";
            request.AddParameter("cancellationCode", cancellationCode, ParameterType.UrlSegment);
            var response = _restClient.Execute<Game>(request);
            Game game = response.Data;
            return game;
        }

        //~ ----------------------------------------------------------------------------------------------------------------
        public Game move(string authCode, string piece)
        {
            var request = new RestRequest(Method.PUT);
            request.Resource = "/move/{authCode}/{piece}";
            request.AddParameter("authCode", authCode, ParameterType.UrlSegment);
            request.AddParameter("piece", piece, ParameterType.UrlSegment);
            var response = _restClient.Execute<Game>(request);
            return response.Data;
        }

        //~ ----------------------------------------------------------------------------------------------------------------
        public Authorization Start()
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/start";
            var response = _restClient.Execute<Authorization>(request);
            
            return response.Data;
        }

        //~ ----------------------------------------------------------------------------------------------------------------

        public Game status()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/status";
            var response = _restClient.Execute<Game>(request);
            Console.Write(response.Content);
            return response.Data;
        }
    }
}
