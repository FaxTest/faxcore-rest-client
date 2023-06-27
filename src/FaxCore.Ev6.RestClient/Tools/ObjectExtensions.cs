using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FaxCore.Ev6.RestClient.Tools
{
    public static class ObjectExtensions
    {
        public static FormUrlEncodedContent ToUrlEncodedContent<T>(this T obj)
            where T : class
        {
            if (obj == null) return null;
            var properties = obj.GetType().GetProperties();
            // use Linq to build up the form data including child objects
            var keyValuePairs = new List<KeyValuePair<string, string>>();
            getProperties(obj, keyValuePairs);
            var content = new FormUrlEncodedContent(keyValuePairs);
            return content;
        }

        private static void getProperties<T>(T obj, List<KeyValuePair<string, string>> formData)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(obj, null);
                if (value == null) continue;
                if (isSimpleType(property.PropertyType))
                    formData.Add(new KeyValuePair<string, string>(property.Name, value.ToString()));
                else
                    getProperties(value, formData);
            }
        }

        private static bool isSimpleType(Type type)
        {
            return type.IsPrimitive
                   || type.IsEnum
                   || type == typeof(string)
                   || type == typeof(decimal);
        }
    }
}