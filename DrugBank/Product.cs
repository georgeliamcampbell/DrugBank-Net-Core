using System.Xml.Serialization;

namespace DrugBank
{
    public class Product
    {

        [XmlElement("name")]
        public virtual string Name { get; set; }

        [XmlElement("labeller")]
        public virtual string Labeller { get; set; }

        [XmlElement("ndc-id")]
        public virtual string NDCId { get; set; }

        [XmlElement("ndc-product-code")]
        public virtual string NDCProductCode { get; set; }

        [XmlElement("dpd-id")]
        public virtual string DPDId { get; set; }

        [XmlElement("ema-product-code")]
        public virtual string EMAProductCode { get; set; }

        [XmlElement("ema-ma-number")]
        public virtual string EMAMaNumber { get; set; }

        [XmlElement("started-marketing-on")]
        public virtual string StartedMarketingOn { get; set; }

        [XmlElement("ended-marketing-on")]
        public virtual string EndedMarketingOn { get; set; }

        [XmlElement("dosage-form")]
        public virtual string DosageForm { get; set; }

        [XmlElement("strength")]
        public virtual string Strength { get; set; }

        [XmlElement("route")]
        public virtual string Route { get; set; }

        [XmlElement("fda-application-number")]
        public virtual string FDAApplicationNumber { get; set; }

        [XmlElement("generic")]
        public virtual bool Generic { get; set; }

        [XmlElement("over-the-counter")]
        public virtual bool OverTheCounter { get; set; }

        [XmlElement("approved")]
        public virtual bool Approved { get; set; }

        [XmlElement("country")]
        public virtual ProductCountry Country { get; set; }

        [XmlElement("source")]
        public virtual ProductSource Source { get; set; }

    }
}