using System.Xml.Serialization;

namespace DrugBank
{
    public class Link
    {

        [XmlElement("ref-id")]
        public virtual string RefId { get; set; }

        [XmlElement("title")]
        public virtual string Title { get; set; }

        [XmlElement("url")]
        public virtual string URL { get; set; }

    }
}