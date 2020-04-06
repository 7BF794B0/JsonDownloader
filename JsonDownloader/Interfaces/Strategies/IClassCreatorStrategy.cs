namespace JsonDownloader.Interfaces
{
    interface IClassCreatorStrategy
    {
        IStatusCode SetupClassCreator();

        object CreateClass(IUrl url);
    }
}
