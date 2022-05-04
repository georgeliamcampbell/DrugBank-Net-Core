using System.Xml.Serialization;

namespace DrugBank
{
    public class Synonym
    {

        [XmlAttribute("language")]
        public virtual string Language { get; set; }

        [XmlAttribute("coder")]
        public virtual string Coder { get; set; }

        [XmlText]
        public virtual string Value { get; set; }

    }
}