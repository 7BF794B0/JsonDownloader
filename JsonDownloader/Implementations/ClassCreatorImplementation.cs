using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class ClassCreatorImplementation : IClassCreator
    {
        public IClassCreatorStrategy GetClassCreatorStrategy()
        {
            throw new System.NotImplementedException();
        }

        public (IStatusCode, string) CreateClass(IClassCreatorStrategy strategy)
        {
            throw new System.NotImplementedException();
        }
    }
}
