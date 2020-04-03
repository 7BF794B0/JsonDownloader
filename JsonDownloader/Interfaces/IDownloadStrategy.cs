namespace JsonDownloader.Interfaces
{
    interface IDownloadStrategy
    {
        IStatusCode SetupDownloader();

        (IStatusCode, string) Download(IUrl str);
    }
}
