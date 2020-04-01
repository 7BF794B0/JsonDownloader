using JsonDownloader.Entities;
using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class EndPointContextImplementation : IUrl
    {
        private readonly string _path;

        public EndPointContextImplementation(string path)
        {
            _path = path;
        }

        public Url GetUrlContext()
        {
            ContextFactory factory = ContextFactory.getInstance();
            Url s = factory.createUrlContext(_path);
            return s;
        }
    }
}
