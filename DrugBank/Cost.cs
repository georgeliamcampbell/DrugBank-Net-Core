using System.Xml.Serialization;

namespace DrugBank
{
    public class Cost
    {

        [XmlAttribute("currency")]
        public virtual string Currency { get; set; }

        [XmlText]
        public virtual string Value { get; set; } // TODO: Drugbank XML schema defines the cost value as a string
                                                  //       but it would be much better to have it serialized as a
                                                  //       floating point.

    }
}