using System.Xml.Serialization;

namespace DrugBank
{
    public class DrugCategory
    {

        [XmlElement("category")]
        public virtual string Category { get; set; }

        [XmlElement("mesh-id")]
        public virtual string MeshId { get; set; }

    }
}