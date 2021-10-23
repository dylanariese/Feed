using System.Xml.Serialization;

namespace Feed.Data.Classes.Feed
{
    [XmlRoot(ElementName = "rss")]
    public class Rss
    {
        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }
        [XmlAttribute(AttributeName = "atom", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Atom { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "media", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Media { get; set; }
        [XmlAttribute(AttributeName = "dc", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Dc { get; set; }
    }
}