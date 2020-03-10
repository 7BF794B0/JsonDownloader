namespace JsonDownloader.Interfaces
{
    interface IEndPoint
    {
        IUrl GetUrl();

        IDownloadStrategy GetDownloadStrategy();

        IStatusCode Download(IDownloadStrategy strategy, IUrl toDownload);
    }
}
