namespace JsonDownloader.Interfaces
{
    interface IDownloadStrategy
    {
        IStatusCode SetupDownloader();

        IStatusCode Download(IUrl str);
    }
}
