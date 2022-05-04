using System.Xml.Serialization;

namespace DrugBank
{
    public class Article
    {

        [XmlElement("ref-id")]
        public virtual string RefId { get; set; }

        [XmlElement("pubmed-id")]
        public virtual string PubMedId { get; set; }

        [XmlElement("citation")]
        public virtual string Citation { get; set; }

    }
}