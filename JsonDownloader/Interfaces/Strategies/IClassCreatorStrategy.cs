namespace JsonDownloader.Interfaces
{
    interface IClassCreatorStrategy
    {
        IStatusCode SetupClassCreator(string body);

        object CreateClass();
    }
}
