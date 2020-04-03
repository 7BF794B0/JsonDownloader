using System.Configuration;
using JsonDownloader;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager.InstantiateManagerAndRun(ConfigurationManager.AppSettings["json_url"]);
        }
    }
}
