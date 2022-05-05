using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DrugBank
{
    public class Drug
    {

        [XmlElement("drugbank-id")]
        public virtual List<DrugBankId> DrugBankIds { get; set; }

        [XmlElement("name")]
        public virtual string Name { get; set; }

        [XmlElement("description")]
        public virtual string Description { get; set; }

        [XmlElement("cas-number")]
        public virtual string CASNumber { get; set; }

        [XmlElement("unii")]
        public virtual string UNII { get; set; }

        [XmlElement("average-mass")]
        public virtual float? AverageMass { get; set; }

        [XmlElement("monoisotopic-mass")]
        public virtual float? MonoisotopicMass { get; set; }

        [XmlElement("state")]
        public virtual DrugState? State { get; set; }

        [XmlArray("groups")]
        [XmlArrayItem("group")]
        public virtual List<DrugGroup> Groups { get; set; }

        [XmlElement("general-references")]
        public virtual References GeneralReferences { get; set; }

        [XmlElement("synthesis-reference")]
        public virtual string SynthesisReference { get; set; }

        [XmlElement("indication")]
        public virtual string Indication { get; set; }

        [XmlElement("pharmacodynamics")]
        public virtual string Pharmacodynamics { get; set; }

        [XmlElement("mechanism-of-action")]
        public virtual string MechanismOfAction { get; set; }

        [XmlElement("toxicity")]
        public virtual string Toxicity { get; set; }

        [XmlElement("metabolism")]
        public virtual string Metabolism { get; set; }

        [XmlElement("absorption")]
        public virtual string Absorption { get; set; }

        [XmlElement("half-life")]
        public virtual string HalfLife { get; set; }

        [XmlElement("protein-binding")]
        public virtual string ProteinBinding { get; set; }

        [XmlElement("route-of-elimination")]
        public virtual string RouteOfElimination { get; set; }

        [XmlElement("volume-of-distribution")]
        public virtual string VolumeOfDistribution { get; set; }

        [XmlElement("clearance")]
        public virtual string Clearance { get; set; }

        [XmlElement("classification")]
        public virtual Classification Classification { get; set; }

        [XmlArray("salts")]
        [XmlArrayItem("salt")]
        public virtual List<DrugSalt> Salts { get; set; }

        [XmlArray("synonyms")]
        [XmlArrayItem("synonym")]
        public virtual List<Synonym> Synonyms { get; set; }

        [XmlArray("products")]
        [XmlArrayItem("product")]
        public virtual List<Product> Products { get; set; }

        [XmlArray("international-brands")]
        [XmlArrayItem("international-brand")]
        public virtual List<InternationalBrand> InternationalBrands { get; set; }

        [XmlArray("mixtures")]
        [XmlArrayItem("mixture")]
        public virtual List<Mixture> Mixtures { get; set; }

        [XmlArray("packagers")]
        [XmlArrayItem("packager")]
        public virtual List<Packager> Packagers { get; set; }

        [XmlArray("manufacturers")]
        [XmlArrayItem("manufacturer")]
        public virtual List<Manufacturer> Manufacturers { get; set; }

        [XmlArray("prices")]
        [XmlArrayItem("price")]
        public virtual List<Price> Prices { get; set; }

        [XmlArray("categories")]
        [XmlArrayItem("category")]
        public virtual List<DrugCategory> Categories { get; set; }

        [XmlArray("affected-organisms")]
        [XmlArrayItem("affected-organism")]
        public virtual List<string> AffectedOrganisms { get; set; }

        [XmlArray("dosages")]
        [XmlArrayItem("dosage")]
        public virtual List<Dosage> Dosages { get; set; }

        [XmlArray("atc-codes")]
        [XmlArrayItem("atc-code")]
        public virtual List<ATCCode> ATCCodes { get; set; }

        [XmlArray("ahfs-codes")]
        [XmlArrayItem("ahfs-code")]
        public virtual List<string> AHFSCodes { get; set; }

        [XmlArray("pdb-entries")]
        [XmlArrayItem("pdb-entry")]
        public virtual List<string> PDBEntries { get; set; }

        [XmlElement("fda-label")]
        public virtual string FDALabel { get; set; }

        [XmlElement("msds")]
        public virtual string MSDS { get; set; }

        [XmlArray("patents")]
        [XmlArrayItem("patent")]
        public virtual List<Patent> Patents { get; set; }

        [XmlArray("food-interactions")]
        [XmlArrayItem("food-interaction")]
        public virtual List<string> FoodInteractions { get; set; }

        [XmlArray("drug-interactions")]
        [XmlArrayItem("drug-interaction")]
        public virtual List<DrugInteraction> DrugInteractions { get; set; }

        [XmlArray("sequences")]
        [XmlArrayItem("sequence")]
        public virtual List<DrugSequence> Sequences { get; set; }

        // Calculated Properties
        [XmlArray("calculated-properties")]
        [XmlArrayItem("property")]
        public virtual List<CalculatedProperty> CalculatedProperties { get; set; }

        // Experimental Properties
        [XmlArray("experimental-properties")]
        [XmlArrayItem("property")]
        public virtual List<ExperimentalProperty> ExperimentalProperties { get; set; }

        //External Identifiers
        [XmlArray("external-identifiers")]
        [XmlArrayItem("external-identifier")]
        public virtual List<ExternalIdentifier> ExternalIdentifiers { get; set; }

        //External Links
        [XmlArray("external-links")]
        [XmlArrayItem("external-link")]
        public virtual List<ExternalLink> ExternalLinks { get; set; }

        //TODO: Pathways

        //TODO: Reactions

        //TODO: SNP Effects

        //TODO: SNP Adverse Drug Reactions

        //TODO: Targets

        //TODO: Enzymes

        //TODO: Carriers

        //TODO: Transporters

        [XmlAttribute("type")]
        public virtual DrugType Type { get; set; }

        [XmlAttribute("created")]
        public virtual DateTime Created { get; set; }

        [XmlAttribute("updated")]
        public virtual DateTime Updated { get; set; }

    }
}