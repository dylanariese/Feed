using System.Xml.Serialization;

namespace Feed.Data.Classes.Feed
{
    [XmlRoot(ElementName = "guid")]
    public class Guid
    {
        [XmlAttribute(AttributeName = "isPermaLink")]
        public string IsPermaLink { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
