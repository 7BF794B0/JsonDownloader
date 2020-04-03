namespace JsonDownloader.Interfaces
{
    interface IClassCreator
    {
        IClassCreatorStrategy GetClassCreatorStrategy(string body);

        object CreateClass(IClassCreatorStrategy strategy);
    }
}
