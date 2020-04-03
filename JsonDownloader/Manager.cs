using JsonDownloader.Exceptions;
using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader
{
    public class Manager
    {
        private static Manager _instance;

        public static void InstantiateManagerAndRun(string path)
        {
            _instance = new Manager(path);
        }

        public Manager(string PATH)
        {
            EndPointFactory factory = EndPointFactory.GetInstance();
            IEndPoint endPoint = factory.CreateEndPoint();
            IUrl url = endPoint.GetUrl(PATH);
            IDownloadStrategy downloadStrategy = endPoint.GetDownloadStrategy();
            (IStatusCode, string) result = endPoint.Download(downloadStrategy, url);
            if (result.Item1.GetStatusCode() != 0)
            {
                throw new RuntimeException("Failed to download: " + result.Item1.GetStatusCode());
            }
            else
            {
                System.Console.WriteLine(result.Item2);
            }
        }
    }
}
