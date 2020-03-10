using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class EndPointImplementation : IEndPoint
    {
        public IUrl GetUrl()
        {
            throw new System.NotImplementedException();
        }

        public IDownloadStrategy GetDownloadStrategy()
        {
            throw new System.NotImplementedException();
        }

        public IStatusCode Download(IDownloadStrategy strategy, IUrl toDownload)
        {
            throw new System.NotImplementedException();
        }
    }
}
