using JsonDownloader.Entities;
using JsonDownloader.Interfaces;
using System;
using System.Net;

namespace JsonDownloader.Implementations
{
	class DownloadStrategyImplementation : IDownloadStrategy
	{
		private WebClient wc;

		public (IStatusCode, string) Download(IUrl str)
		{
			try
			{
				var json = wc.DownloadString(str.GetUrlContext().UrlStr);
				return (new StatusCodeImplementation(0), json);
			}
			catch (Exception e)
			{
				return (new StatusCodeImplementation(-1), null);
			}
		}

		public IStatusCode SetupDownloader()
		{
			try
			{
				wc = new WebClient();
				return new StatusCodeImplementation(0);
			}
			catch (Exception e)
			{
				return new StatusCodeImplementation(-1);
			}
		}
	}
}
