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
            EndPointFactory factory = EndPointFactory.GetInstance();
            IEndPoint endPoint = factory.CreateEndPoint();
            IUrl url = endPoint.GetUrl(PATH);
            IDownloadStrategy downloadStrategy = endPoint.GetDownloadStrategy();
            (IStatusCode, string) result = endPoint.Download(downloadStrategy, url);
            if (result.Item1.GetStatusCode() != 0)
            {
                throw new RuntimeException("Failed to download: " + result.Item1.GetStatusCode());
            }
            else
            {
                List<Dictionary<string, JToken>> lst = new List<Dictionary<string, JToken>>();

                dynamic stuff = JsonConvert.DeserializeObject(result.Item2);

                foreach (JObject jObj in stuff)
                {
                    Dictionary<string, JToken> dict = new Dictionary<string, JToken>();

                    var rootProperties = jObj.Children().OfType<JProperty>().Select(p => p.Name).ToArray();
                    foreach (var property in rootProperties)
                    {
                        dict.Add(property, jObj.Property(property).Value);
                    }
                    lst.Add(dict);
                }
            }
        }
    }
}
