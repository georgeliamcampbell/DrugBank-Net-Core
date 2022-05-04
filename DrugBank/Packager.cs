using System.Xml.Serialization;

namespace DrugBank
{
    public class Packager
    {

        [XmlElement("name")]
        public virtual string Name { get; set; }

        [XmlElement("url")]
        public virtual string URL { get; set; }

    }
}