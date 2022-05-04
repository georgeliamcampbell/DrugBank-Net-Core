using System.Xml.Serialization;

namespace DrugBank
{
    public class DrugSalt
    {

        [XmlElement("drugbank-id")]
        public virtual List<DrugBankId> DrugBankIds { get; set; }

        [XmlElement("name")]
        public virtual string Name { get; set; }

        [XmlElement("unii")]
        public virtual string UNII { get; set; }

        [XmlElement("cas-number")]
        public virtual string CASNumber { get; set; }

        [XmlElement("inchikey")]
        public virtual string InChI { get; set; }

        [XmlElement("average-mass")]
        public virtual float? AverageMass { get; set; }

        [XmlElement("monoisotopic-mass")]
        public virtual float? MonoisotopicMass { get; set; }

    }
}