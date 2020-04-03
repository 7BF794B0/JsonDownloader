using System;
using System.Configuration;
using JsonDownloader;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var kek = Manager.InstantiateManagerAndRun(ConfigurationManager.AppSettings["json_url"]);
            Console.ReadKey();
        }
    }
}
