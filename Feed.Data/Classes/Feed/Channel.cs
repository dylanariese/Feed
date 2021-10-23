using System.Collections.Generic;
using System.Xml.Serialization;

namespace Feed.Data.Classes.Feed
{
    [XmlRoot(ElementName = "channel")]
    public class Channel
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "link")]
        public List<string> Link { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
        [XmlElement(ElementName = "copyright")]
        public string Copyright { get; set; }
        [XmlElement(ElementName = "lastBuildDate")]
        public string LastBuildDate { get; set; }
        [XmlElement(ElementName = "ttl")]
        public string Ttl { get; set; }
        [XmlElement(ElementName = "logo", Namespace = "http://www.w3.org/2005/Atom")]
        public string Logo { get; set; }
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }
}
