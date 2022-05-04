using System.Xml.Serialization;

namespace DrugBank
{
    public class Classification
    {

        [XmlElement("description")]
        public virtual string Description { get; set; }

        [XmlElement("direct-parent")]
        public virtual string DirectParent { get; set; }

        [XmlElement("kingdom")]
        public virtual string Kingdom { get; set; }

        [XmlElement("superclass")]
        public virtual string SuperClass { get; set; }
        
        [XmlElement("class")]
        public virtual string Class { get; set; }
        
        [XmlElement("subclass")]
        public virtual string SubClass { get; set; }

        [XmlElement("alternative-parent")]
        public virtual List<string> AlternativeParents { get; set; }
        
        [XmlElement("substituent")]
        public virtual List<string> Substituents { get; set; }

    }
}