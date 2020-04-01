using JsonDownloader.Entities;

namespace JsonDownloader.Factories
{
    class ContextFactory
    {
		private static ContextFactory instance = new ContextFactory();

		public static ContextFactory getInstance()
		{
			return instance;
		}

		public Url createUrlContext(string path)
		{
			Url s = new Url(path);
			return s;
		}
	}
}
