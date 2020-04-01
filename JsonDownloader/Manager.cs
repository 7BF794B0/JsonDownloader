using JsonDownloader.Exceptions;
using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader
{
    public class Manager
    {
        private static Manager instance;

        public static void instantiateManagerAndRun()
        {
            instance = new Manager();
        }

        public Manager()
        {
            // TODO: Переделать офк
            string PATH = @"https://dka-develop.ru/api?type=city";

            EndPointFactory factory = EndPointFactory.GetInstance();
            IEndPoint endPoint = factory.CreateEndPoint();
            IUrl url = endPoint.GetUrl(PATH);
            IDownloadStrategy downloadStrategy = endPoint.GetDownloadStrategy();
            IStatusCode code = endPoint.Download(downloadStrategy, url);
            if (code.GetStatusCode() != 0)
            {
                throw new RuntimeException("Failed to download: " + code.GetStatusCode());
            }
        }
    }
}
