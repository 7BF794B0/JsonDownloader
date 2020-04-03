using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class EndPointImplementation : IEndPoint
    {
        public IUrl GetUrl(string path)
        {
            IUrl url = new EndPointContextImplementation(path);
            return url;
        }

        public IDownloadStrategy GetDownloadStrategy()
        {
            DownloadStrategyFactory factory = DownloadStrategyFactory.GetInstance();
            return factory.createIPrintStrategy();
        }

        public (IStatusCode, string) Download(IDownloadStrategy strategy, IUrl toDownload)
        {
            (IStatusCode, string) result = strategy.Download(toDownload);
            return (result.Item1, result.Item2);
        }
    }
}
