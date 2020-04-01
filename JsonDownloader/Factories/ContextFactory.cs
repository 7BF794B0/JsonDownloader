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

		public Url createUrlContext()
		{
			Url s = new Url();
			return s;
		}
	}
}
