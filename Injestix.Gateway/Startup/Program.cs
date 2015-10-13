using Injestix.Gateway.Properties;
using Nancy.Hosting.Self;
using System;
using System.Threading;

namespace Injestix.Gateway
{
    public class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri(Settings.Default.Endpoint);
            var bootstrapper = new Bootstrapper();
            var hostConfig = new HostConfiguration { UrlReservations = new UrlReservations { CreateAutomatically = true } };
            var host = new NancyHost(bootstrapper, hostConfig, uri);

            using (host)
            {
                host.Start();
                Console.Out.WriteLine("Application running on: {0}", Settings.Default.Endpoint);
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}
