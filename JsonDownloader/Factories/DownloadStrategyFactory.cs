﻿using JsonDownloader.Exceptions;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Factories
{
    class DownloadStrategyFactory
    {
		private static DownloadStrategyFactory instance = new DownloadStrategyFactory();

		public static DownloadStrategyFactory getInstance()
		{
			return instance;
		}

		public IDownloadStrategy createIPrintStrategy()
		{
			IDownloadStrategy printStrategy = new DownloadStrategyImplementation();
			IStatusCode code = printStrategy.setupPrinting();

			if (code.GetStatusCode() != 0)
				throw new RuntimeException("Failed to create IPrintStrategy: " + code.GetStatusCode());

			return printStrategy;
		}
	}
}