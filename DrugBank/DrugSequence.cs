using System.Xml.Serialization;

namespace DrugBank
{
    public class DrugSequence
    {

        [XmlAttribute("format")]
        public virtual string Format { get; set; }

        [XmlText]
        public virtual string Sequence { get; set; }

    }
}