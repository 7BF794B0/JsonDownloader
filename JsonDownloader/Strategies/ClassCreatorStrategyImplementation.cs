using System;
using System.Collections.Generic;
using System.Linq;
using JsonDownloader.Entities;
using JsonDownloader.Implementations.Wrappers;
using JsonDownloader.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDownloader.Implementations
{
    class ClassCreatorStrategyImplementation : IClassCreatorStrategy
    {
        public object CreateClass(IUrl url)
        {
            List<Dictionary<string, dynamic>> lst = new List<Dictionary<string, dynamic>>();

            dynamic stuff = JsonConvert.DeserializeObject(url.GetUrlContext().Body);

            foreach (JObject jObj in stuff)
            {
                Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();

                var rootProperties = jObj.Children().OfType<JProperty>().Select(p => p.Name).ToArray();
                foreach (var property in rootProperties)
                {
                    dict.Add(property, jObj.Property(property).Value.ToString());
                }
                lst.Add(dict);
            }

            return (from l in lst select new DynamicDictionaryWrapper(l)).ToList();
        }

        public IStatusCode SetupClassCreator()
        {
            try
            {
                return new StatusCodeImplementation(0);
            }
            catch (Exception e)
            {
                return new StatusCodeImplementation(-1);
            }
        }
    }
}
