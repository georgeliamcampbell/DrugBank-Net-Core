using System.Xml.Serialization;

namespace DrugBank
{
    public class DrugInteraction
    {

        [XmlElement("drugbank-id")]
        public virtual DrugBankId DrugBankId { get; set; }

        [XmlElement("name")]
        public virtual string Name { get; set; }

        [XmlElement("description")]
        public virtual string Description { get; set; }

    }
}