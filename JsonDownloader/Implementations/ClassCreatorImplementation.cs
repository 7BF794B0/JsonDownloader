using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class ClassCreatorImplementation : IClassCreator
    {
        public IClassCreatorStrategy GetClassCreatorStrategy(string body)
        {
            ClassCreatorStrategyFactory factory = ClassCreatorStrategyFactory.GetInstance();
            return factory.CreateClassCreatorStrategy(body);
        }

        public (IStatusCode, string) CreateClass(IClassCreatorStrategy strategy)
        {
            throw new System.NotImplementedException();
        }
    }
}
