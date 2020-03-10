using JsonDownloader.Implementations;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Factories
{
    class EndPointFactory
    {
		private static readonly EndPointFactory instance = new EndPointFactory();

		public static EndPointFactory GetInstance()
		{
			return instance;
		}

		public IEndPoint CreateEndPoint()
		{
			IEndPoint endPoint = new EndPointImplementation();
			return endPoint;
		}
	}
}
