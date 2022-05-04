using System.Xml.Serialization;

namespace DrugBank
{
    public enum DrugGroup
    {
        [XmlEnum("approved")] APPROVED,
        [XmlEnum("illicit")] ILLICIT,
        [XmlEnum("experimental")] EXPERIMENTAL,
        [XmlEnum("withdrawn")] WITHDRAWN,
        [XmlEnum("nutraceutical")] NUTRACEUTICAL,
        [XmlEnum("investigational")] INVESTIGATIONAL,
        [XmlEnum("vet_approved")] VET_APPROVED
    }
}