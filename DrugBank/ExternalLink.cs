using System.Xml.Serialization;

namespace DrugBank
{
    public class ExternalLink
    {

        [XmlElement("resource")]
        public virtual ExternalLinkResource Resource { get; set; }

        [XmlElement("url")]
        public virtual string URL { get; set; }

    }
}