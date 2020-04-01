using JsonDownloader.Entities;
using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class EndPointContextImplementation : IUrl
    {
        public Url GetUrlContext(string path)
        {
            ContextFactory factory = ContextFactory.getInstance();
            Url s = factory.createUrlContext(path);
            return s;
        }
    }
}
