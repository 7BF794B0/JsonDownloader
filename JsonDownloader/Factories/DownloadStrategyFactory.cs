using JsonDownloader.Exceptions;
using JsonDownloader.Implementations;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Factories
{
    class DownloadStrategyFactory
    {
		private static DownloadStrategyFactory instance = new DownloadStrategyFactory();

		public static DownloadStrategyFactory GetInstance()
		{
			return instance;
		}

		public IDownloadStrategy CreateDownloadStrategy()
		{
			IDownloadStrategy downloadStrategy = new DownloadStrategyImplementation();
			IStatusCode code = downloadStrategy.SetupDownloader();

			if (code.GetStatusCode() != 0)
				throw new RuntimeException("Failed to create IDownloadStrategy: " + code.GetStatusCode());

			return downloadStrategy;
		}
	}
}
