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
            throw new System.NotImplementedException();
        }

        public IStatusCode Download(IDownloadStrategy strategy, IUrl toDownload)
        {
            throw new System.NotImplementedException();
        }
    }
}
