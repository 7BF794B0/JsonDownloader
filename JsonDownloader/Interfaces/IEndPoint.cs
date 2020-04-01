namespace JsonDownloader.Interfaces
{
    interface IEndPoint
    {
        IUrl GetUrl(string path);

        IDownloadStrategy GetDownloadStrategy();

        IStatusCode Download(IDownloadStrategy strategy, IUrl toDownload);
    }
}
