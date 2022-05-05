using System.Xml.Serialization;

namespace DrugBank
{
    public enum ExternalIdentifierResource
    {
        [XmlEnum("UniProtKB")] UNI_PROT_KB,
        [XmlEnum("Wikipedia")] WIKIPEDIA,
        [XmlEnum("ChEBI")] CHEBI,
        [XmlEnum("ChEMBL")] CHEMBL,
        [XmlEnum("PubChem Compound")] PUBCHEM_COMPOUND,
        [XmlEnum("PubChem Substance")] PUBCHEM_SUBSTANCE,
        [XmlEnum("Drugs Product Database (DPD)")] DRUGS_PRODUCT_DATABASE,
        [XmlEnum("KEGG Compound")] KEGG_COMPOUND,
        [XmlEnum("KEGG Drug")] KEGG_DRUG,
        [XmlEnum("ChemSpider")] CHEMSPIDER,
        [XmlEnum("BindingDB")] BINDING_DB,
        [XmlEnum("National Drug Code Directory")] NATIONAL_DRUG_CODE_DIRECTORY,
        [XmlEnum("GenBank")] GENBANK,
        [XmlEnum("Therapeutic Targets Database")] THERAPEUTIC_TARGETS_DATABASE,
        [XmlEnum("PharmGKB")] PHARM_GKB,
        [XmlEnum("PDB")] PDB,
        [XmlEnum("IUPHAR")] IUPHAR,
        [XmlEnum("Guide to Pharmacology")] GUIDE_TO_PHARMACOLOGY,
        [XmlEnum("ZINC")] ZINC,
        [XmlEnum("RxCUI")] RXCUI
    }
}