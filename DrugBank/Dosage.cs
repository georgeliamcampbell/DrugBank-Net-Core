using System.Xml.Serialization;

namespace DrugBank
{
    public class Dosage
    {

        [XmlElement("form")]
        public virtual string Form { get; set; }

        [XmlElement("route")]
        public virtual string Route { get; set; }

        [XmlElement("strength")]
        public virtual string Strength { get; set; }

    }
}