using System.Xml.Serialization;

namespace DrugBank
{
    public class ATCCode
    {

        [XmlAttribute("code")]
        public virtual string Code { get; set; }

        [XmlElement("level")]
        public virtual List<ATCLevel> Levels { get; set; }

    }
}