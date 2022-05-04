using System.Xml.Serialization;

namespace DrugBank
{
    public class ATCLevel
    {

        [XmlAttribute("code")]
        public virtual string Code { get; set; }

        [XmlText]
        public virtual string Name { get; set; }

    }
}