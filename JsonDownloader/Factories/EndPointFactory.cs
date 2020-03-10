namespace JsonDownloader.Factories
{
    class EndPointFactory
    {
		private static EndPointFactory instance = new EndPointFactory();

		public static EndPointFactory getInstance()
		{
			return instance;
		}
	}
}
