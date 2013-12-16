using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    internal class GameClient
    {
        private readonly RestClient _restClient;

        public GameClient(string baseUrl)
        {
            _restClient = new RestClient {BaseUrl = baseUrl};
        }

        //~ ----------------------------------------------------------------------------------------------------------------
        public GameStatus Cancel(string cancellationCode)
        {
            var request = new RestRequest(Method.DELETE) {Resource = "/cancel/{cancellationCode}"};
            request.AddParameter("cancellationCode", cancellationCode, ParameterType.UrlSegment);
            var response = _restClient.Execute<GameStatus>(request);
            return response.Data;
        }

        //~ ----------------------------------------------------------------------------------------------------------------
        public GameStatus Move(string authCode, string piece)
        {
            var request = new RestRequest(Method.PUT) {Resource = "/move/{authCode}/{piece}"};
            request.AddParameter("authCode", authCode, ParameterType.UrlSegment);
            request.AddParameter("piece", piece, ParameterType.UrlSegment);
            var response = _restClient.Execute<GameStatus>(request);
            return response.Data;
        }

        //~ ----------------------------------------------------------------------------------------------------------------
        public Authorization Start()
        {
            var request = new RestRequest(Method.POST) {Resource = "/start"};
            var response = _restClient.Execute<Authorization>(request);
            return response.Data;
        }

        //~ ----------------------------------------------------------------------------------------------------------------
        public GameStatus GetStatus()
        {
            var request = new RestRequest(Method.GET) {Resource = "/status"};
            var response = _restClient.Execute<GameStatus>(request);
            return response.Data;
        }
    }
}