using System.Xml.Serialization;

namespace DrugBank
{
    public enum ProductSource
    {
        [XmlEnum("FDA NDC")] FDA_NDC,
        [XmlEnum("DPD")] DPD,
        [XmlEnum("EMA")] EMA
    }
}