using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class EndPointImplementation : IEndPoint
    {
        public IUrl GetUrl()
        {
            IUrl url = new EndPointContextImplementation();
            return url;
        }

        public IDownloadStrategy GetDownloadStrategy()
        {
            DownloadStrategyFactory factory = DownloadStrategyFactory.GetInstance();
            return factory.createIPrintStrategy();
        }

        public IStatusCode Download(IDownloadStrategy strategy, IUrl toDownload)
        {
            throw new System.NotImplementedException();
        }
    }
}
