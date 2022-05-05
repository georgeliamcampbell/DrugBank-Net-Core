using System.Xml.Serialization;

namespace DrugBank
{
    public enum ExternalLinkResource
    {
        [XmlEnum("RxList")] RX_LIST,
        [XmlEnum("PDRhealth")] PDR_HEALTH,
        [XmlEnum("Drugs.com")] DRUGS_COM
    }
}