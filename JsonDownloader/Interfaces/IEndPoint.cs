namespace JsonDownloader.Interfaces
{
    interface IEndPoint
    {
        IUrl GetUrl(string path);

        IDownloadStrategy GetDownloadStrategy();

        (IStatusCode, string) Download(IDownloadStrategy strategy, IUrl toDownload);
    }
}
