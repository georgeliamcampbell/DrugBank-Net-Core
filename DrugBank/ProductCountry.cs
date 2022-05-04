using System.Xml.Serialization;

namespace DrugBank
{
    public enum ProductCountry
    {
        [XmlEnum("US")] US,
        [XmlEnum("Canada")] CANADA,
        [XmlEnum("EU")] EU
    }
}