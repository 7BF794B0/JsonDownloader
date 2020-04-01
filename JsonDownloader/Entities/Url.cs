namespace JsonDownloader.Entities
{
    class Url
    {
        public string UrlStr { get; private set; }

        public Url(string path)
        {
            UrlStr = path;
        }
    }
}
