namespace JsonDownloader.Interfaces
{
    interface IClassCreator
    {
        IClassCreatorStrategy GetClassCreatorStrategy();

        object CreateClass(IClassCreatorStrategy strategy, IUrl url);
    }
}
