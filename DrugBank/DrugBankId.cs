using System.Xml.Serialization;

namespace DrugBank
{
    public class DrugBankId
    {

        [XmlAttribute("primary")]
        public virtual bool Primary { get; set; }

        [XmlText]
        public virtual string Value { get; set; }

    }
}