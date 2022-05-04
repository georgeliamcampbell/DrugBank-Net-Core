using System.Xml.Serialization;

namespace DrugBank
{
    public class References
    {

        [XmlArray("articles")]
        [XmlArrayItem("article")]
        public virtual List<Article> Articles { get; set; }

        [XmlArray("textbooks")]
        [XmlArrayItem("textbook")]
        public virtual List<Textbook> Textbooks { get; set; }

        [XmlArray("links")]
        [XmlArrayItem("link")]
        public virtual List<Link> Links { get; set; }
        
        [XmlArray("attachments")]
        [XmlArrayItem("attachment")]
        public virtual List<Attachment> Attachments { get; set; }
    }
}