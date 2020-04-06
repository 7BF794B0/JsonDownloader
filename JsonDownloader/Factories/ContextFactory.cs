using JsonDownloader.Entities;

namespace JsonDownloader.Factories
{
    class ContextFactory
    {
		private static readonly ContextFactory _instance = new ContextFactory();

		public static ContextFactory GetInstance()
		{
			return _instance;
		}

		public Url CreateUrlContext(string path, string body)
		{
			Url s = new Url(path, body);
			return s;
		}
	}
}
