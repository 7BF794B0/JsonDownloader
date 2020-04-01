using JsonDownloader.Entities;
using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class EndPointContextImplementation : IUrl
    {
        public Url GetUrlContext()
        {
            ContextFactory factory = ContextFactory.getInstance();
            Url s = factory.createUrlContext();
            return s;
        }
    }
}
