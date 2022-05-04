using System.Xml.Serialization;

namespace DrugBank
{
    public class Textbook
    {

        [XmlElement("ref-id")]
        public virtual string RefId { get; set; }

        [XmlElement("isbn")]
        public virtual string ISBN { get; set; }

        [XmlElement("citation")]
        public virtual string Citation { get; set; }

    }
}