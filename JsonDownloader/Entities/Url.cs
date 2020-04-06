namespace JsonDownloader.Entities
{
    class Url
    {
        public string UrlStr { get; private set; }

        public string Body { get; private set; }

        public Url(string path, string body)
        {
            UrlStr = path;
            Body = body;
        }
    }
}
