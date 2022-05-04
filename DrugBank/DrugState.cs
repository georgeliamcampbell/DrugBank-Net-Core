using System.Xml.Serialization;

namespace DrugBank
{
    public enum DrugState
    {
        [XmlEnum("solid")] SOLID,
        [XmlEnum("liquid")] LIQUID,
        [XmlEnum("gas")] GAS
    }
}