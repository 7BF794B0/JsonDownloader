using JsonDownloader.Exceptions;
using JsonDownloader.Factories;
using JsonDownloader.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace JsonDownloader
{
    public class Manager
    {
        private static Manager _instance;

        public static Manager InstantiateManagerAndRun(string path)
        {
            _instance = new Manager(path);
            return _instance;
        }

        public Manager(string PATH)
        {
            EndPointFactory factory1 = EndPointFactory.GetInstance();
            IEndPoint endPoint = factory1.CreateEndPoint();
            IUrl url = endPoint.GetUrl(PATH);
            IDownloadStrategy downloadStrategy = endPoint.GetDownloadStrategy();
            (IStatusCode, string) result = endPoint.Download(downloadStrategy, url);

            if (result.Item1.GetStatusCode() != 0)
            {
                throw new RuntimeException("Failed to download: " + result.Item1.GetStatusCode());
            }
            else
            {
                ClassCreatorFactory factory2 = ClassCreatorFactory.GetInstance();
                IClassCreator classCreator = factory2.CreateClassCreator();
                IClassCreatorStrategy creatorStrategy = classCreator.GetClassCreatorStrategy();
                var res = classCreator.CreateClass(creatorStrategy);
            }
        }
    }
}
