using Feed.Data.Interfaces;
using System.IO;
using System.Xml.Serialization;

namespace Feed.Infrastructure
{
    public class XmlSerialization : ISerialization
    {
        public T Deserialize<T>(string xml) where T : class
        {
            var serializer = new XmlSerializer(typeof(T));

            using var reader = new StringReader(xml);

            var dtos = (T)serializer.Deserialize(reader);

            return dtos;
        }
    }
}