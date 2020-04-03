namespace JsonDownloader.Interfaces
{
    interface IClassCreator
    {
        IClassCreatorStrategy GetClassCreatorStrategy();

        (IStatusCode, string) CreateClass(IClassCreatorStrategy strategy);
    }
}
