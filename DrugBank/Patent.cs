using System.Xml.Serialization;

namespace DrugBank
{
    public class Patent
    {

        [XmlElement("number")]
        public virtual string Number { get; set; }

        [XmlElement("country")]
        public virtual string Country { get; set; }

        [XmlElement("approved")]
        public virtual string Approved { get; set; } // TODO: Drugbank Schema defines this field as a string but would be better as DateTime?

        [XmlElement("expires")]
        public virtual string Expires { get; set; } // TODO: Drugbank Schema defines this field as a string but would be better as DateTime?

        [XmlElement("pediatric-extension")]
        public virtual bool PediatricExtension { get; set; }

    }
}