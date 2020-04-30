using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrototypeCompleteExample.People
{
    public static class ObjectExtensions
    {
        public static T DeepCopy<T>(this T data)
        {
            var serializeSettings = new JsonSerializerSettings
            {
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                TypeNameHandling = TypeNameHandling.All
            };

            return JsonConvert.DeserializeObject<T>(
                JsonConvert.SerializeObject(data, serializeSettings), 
                serializeSettings);
        }
    }
}
