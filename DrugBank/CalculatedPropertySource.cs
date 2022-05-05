using System.Xml.Serialization;

namespace DrugBank
{
    public enum CalculatedPropertySource
    {
        [XmlEnum("ChemAxon")] CHEM_AXON,
        [XmlEnum("ALOGPS")] ALOGPS
    }
}