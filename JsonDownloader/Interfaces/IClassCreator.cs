namespace JsonDownloader.Interfaces
{
    interface IClassCreator
    {
        IClassCreatorStrategy GetClassCreatorStrategy(string body);

        (IStatusCode, string) CreateClass(IClassCreatorStrategy strategy);
    }
}
