using System.Xml.Serialization;

namespace DrugBank
{
    public enum CalculatedPropertyKind
    {
        [XmlEnum("logP")] LOG_P,
        [XmlEnum("logS")] LOG_S,
        [XmlEnum("Water Solubility")] WATER_SOLUBILITY,
        [XmlEnum("IUPAC Name")] IUPAC_NAME,
        [XmlEnum("Traditional IUPAC Name")] TRADITIONAL_IUPAC_NAME,
        [XmlEnum("Molecular Weight")] MOLECULAR_WEIGHT,
        [XmlEnum("Monoisotopic Weight")] MONOISOTOPIC_WEIGHT,
        [XmlEnum("SMILES")] SMILES,
        [XmlEnum("Molecular Formula")] MOLECULAR_FORMULA,
        [XmlEnum("InChI")] INCHI,
        [XmlEnum("InChIKey")] INCHI_KEY,
        [XmlEnum("Polar Surface Area (PSA)")] POLAR_SURFACE_AREA,
        [XmlEnum("Refractivity")] REFRACTIVITY,
        [XmlEnum("Polarizability")] POLARIZABILITY,
        [XmlEnum("Rotatable Bond Count")] ROTATABLE_BOND_COUNT,
        [XmlEnum("H Bond Acceptor Count")] H_BOND_ACCEPTOR_COUNT,
        [XmlEnum("H Bond Donor Count")] H_BOND_DONOR_COUNT,
        [XmlEnum("pKa (strongest acidic)")] PKA_STRONGEST_ACIDIC,
        [XmlEnum("pKa (strongest basic)")] PKA_STRONGEST_BASIC,
        [XmlEnum("Physiological Charge")] PHYSIOLOGICAL_CHARGE,
        [XmlEnum("Number of Rings")] NUMBER_OF_RINGS,
        [XmlEnum("Bioavailability")] BIOAVAILABILITY,
        [XmlEnum("Rule of Five")] RULE_OF_FIVE,
        [XmlEnum("Ghose Filter")] GHOSE_FILTER,
        [XmlEnum("MDDR-Like Rule")] MDDR_LIKE_RULE,
        [XmlEnum("Veber's Rule")] VEBERS_RULE
    }
}