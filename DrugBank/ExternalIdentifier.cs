using System.Xml.Serialization;

namespace DrugBank
{
    public class ExternalIdentifier
    {

        [XmlElement("resource")]
        public virtual ExternalIdentifierResource Resource { get; set; }

        [XmlElement("identifier")]
        public virtual string Identifier { get; set; }

    }
}