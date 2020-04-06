using JsonDownloader.Exceptions;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class ClassCreatorStrategyFactory
    {
        private static readonly ClassCreatorStrategyFactory _instance = new ClassCreatorStrategyFactory();

        public static ClassCreatorStrategyFactory GetInstance()
        {
            return _instance;
        }

        public IClassCreatorStrategy CreateClassCreatorStrategy()
        {
            IClassCreatorStrategy classCreatorStrategy = new ClassCreatorStrategyImplementation();
            IStatusCode code = classCreatorStrategy.SetupClassCreator();

            if (code.GetStatusCode() != 0)
                throw new RuntimeException("Failed to create IDownloadStrategy: " + code.GetStatusCode());

            return classCreatorStrategy;
        }
    }
}
