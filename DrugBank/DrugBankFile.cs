using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DrugBank
{
    [Serializable]
    [XmlRoot(ElementName = "drugbank", Namespace = "http://www.drugbank.ca")]
    public class DrugBankFile
    {

        [XmlAttribute("version")]
        public virtual string Version { get; set; }

        [XmlAttribute("exported-on")]
        public virtual DateTime Exported { get; set; }

        [XmlElement("drug")]
        public List<Drug> Drugs { get; set; }

    }
}
