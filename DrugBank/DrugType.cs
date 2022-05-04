using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DrugBank
{
    public enum DrugType
    {
        [XmlEnum("small molecule")]SMALL_MOLECULE,
        [XmlEnum("biotech")]BIOTECH
    }
}
