using JsonDownloader.Exceptions;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class ClassCreatorStrategyFactory
    {
        public (IStatusCode, string) CreateClass(IClassCreatorStrategy strategy)
        {
            throw new System.NotImplementedException();
        }

        public IClassCreatorStrategy GetClassCreatorStrategy(string body)
        {
            IClassCreatorStrategy downloadStrategy = new ClassCreatorStrategyImplementation();
            IStatusCode code = downloadStrategy.SetupClassCreator(body);

            if (code.GetStatusCode() != 0)
                throw new RuntimeException("Failed to create IDownloadStrategy: " + code.GetStatusCode());

            return downloadStrategy;
        }
    }
}
