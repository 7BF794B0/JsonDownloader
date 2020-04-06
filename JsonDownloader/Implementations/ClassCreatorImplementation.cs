using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class ClassCreatorImplementation : IClassCreator
    {
        public IClassCreatorStrategy GetClassCreatorStrategy()
        {
            ClassCreatorStrategyFactory factory = ClassCreatorStrategyFactory.GetInstance();
            return factory.CreateClassCreatorStrategy();
        }

        public object CreateClass(IClassCreatorStrategy strategy, IUrl url)
        {
            object result = strategy.CreateClass(url);
            return result;
        }
    }
}
