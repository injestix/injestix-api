using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Injestix.Gateway
{
    public class PingModule : NancyModule
    {
        public PingModule()
            : base("/")
        {
            Get["/"] = (context) =>
            {
                return "pong";
            };
        }
    }
}
