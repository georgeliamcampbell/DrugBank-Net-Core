using System.Xml.Serialization;

namespace DrugBank
{
    public class InternationalBrand
    {

        [XmlElement("name")]
        public virtual string Name { get; set; }

        [XmlElement("company")]
        public virtual string Company { get; set; }

    }
}