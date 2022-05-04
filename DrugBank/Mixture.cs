using System.Xml.Serialization;

namespace DrugBank
{
    public class Mixture
    {

        [XmlElement("name")]
        public virtual string Name { get; set; }

        [XmlElement("ingredients")]
        public virtual string Ingredients { get; set; }

        [XmlElement("supplemental-ingredients")]
        public virtual List<string> SupplementalIngredients { get; set; }
    }
}