using System.Xml.Serialization;

namespace DrugBank
{
    public class Manufacturer
    {

        [XmlAttribute("generic")]
        public virtual bool Generic { get; set; }

        [XmlAttribute("url")]
        public virtual string URL { get; set; }

        [XmlText]
        public virtual string Value { get; set; }

    }
}