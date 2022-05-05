using System.Xml.Serialization;

namespace DrugBank
{
    public class ExperimentalProperty
    {

        [XmlElement("kind")]
        public virtual ExperimentalPropertyKind Kind { get; set; }

        [XmlElement("value")]
        public virtual string Value { get; set; }

        [XmlElement("source")]
        public virtual string Source { get; set; }

    }
}