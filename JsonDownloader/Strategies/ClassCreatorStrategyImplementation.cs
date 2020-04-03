using System;
using System.Collections.Generic;
using System.Linq;
using JsonDownloader.Entities;
using JsonDownloader.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDownloader.Implementations
{
    class ClassCreatorStrategyImplementation : IClassCreatorStrategy
    {
        private string _body;
        public object CreateClass()
        {
            List<Dictionary<string, JToken>> lst = new List<Dictionary<string, JToken>>();

            dynamic stuff = JsonConvert.DeserializeObject(_body);

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

            return new object();
        }

        public IStatusCode SetupClassCreator(string body)
        {
            try
            {
                _body = body;
                return new StatusCodeImplementation(0);
            }
            catch (Exception e)
            {
                return new StatusCodeImplementation(-1);
            }
        }
    }
}
