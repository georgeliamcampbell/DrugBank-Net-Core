using System.Xml.Serialization;

namespace DrugBank
{
    public class CalculatedProperty
    {

        [XmlElement("kind")]
        public virtual CalculatedPropertyKind Kind { get; set; }

        [XmlElement("value")]
        public virtual string Value { get; set; }

        [XmlElement("source")]
        public virtual CalculatedPropertySource Source { get; set; }

    }
}