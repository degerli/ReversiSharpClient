using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiSharpClient
{
    internal class Authorization
    {
        public string CancellationCode { get; set; }
        public string PlayerBlackAuthCode { get; set; }
        public string PlayerWhiteAuthCode { get; set; }
    }
}