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

        public object CreateClass(IClassCreatorStrategy strategy)
        {
            object result = strategy.CreateClass();
            return result;
        }
    }
}
