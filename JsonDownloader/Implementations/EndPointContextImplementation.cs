using JsonDownloader.Entities;
using JsonDownloader.Factories;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Implementations
{
    class EndPointContextImplementation : IUrl
    {
        private readonly string _path;
        private string _body;

        public EndPointContextImplementation(string path)
        {
            _path = path;
        }

        public Url GetUrlContext()
        {
            ContextFactory factory = ContextFactory.GetInstance();
            Url u = factory.CreateUrlContext(_path, _body);
            return u;
        }

        public void SetBody(string body)
        {
            _body = body;
        }
    }
}
