using JsonDownloader.Entities;

namespace JsonDownloader.Interfaces
{
    interface IUrl
    {
        Url GetUrlContext();

        void SetBody(string body);
    }
}
