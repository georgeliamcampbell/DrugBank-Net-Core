using System.Xml.Serialization;

namespace DrugBank
{
    public class Price
    {

        [XmlElement("description")]
        public virtual string Description { get; set; }

        [XmlElement("cost")]
        public virtual Cost Cost { get; set; }

        [XmlElement("unit")]
        public virtual string Unit { get; set; }

    }
}