using System.Xml.Serialization;

namespace DrugBank
{
    public enum ExperimentalPropertyKind
    {
        [XmlEnum("Water Solubility")] WATER_SOLUBILITY,
        [XmlEnum("Melting Point")] MELTING_POINT,
        [XmlEnum("Boiling Point")] BOILING_POINT,
        [XmlEnum("logP")] LOG_P,
        [XmlEnum("logS")] LOG_S,
        [XmlEnum("Hydrophobicity")] HYDROPHOBICITY,
        [XmlEnum("Isoelectric Point")] ISOELECTRIC_POINT,
        [XmlEnum("caco2 Permeability")] CACO2_PERMEABILITY,
        [XmlEnum("pKa")] PKA,
        [XmlEnum("Molecular Weight")] MOLECULAR_WEIGHT,
        [XmlEnum("Molecular Formula")] MOLECULAR_FORMULA,
        [XmlEnum("Radioactivity")] RADIOACTIVITY
    }
}