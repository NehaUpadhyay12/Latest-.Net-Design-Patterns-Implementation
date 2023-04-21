using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Adapter
{
    internal class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJSON = new LumiaJSONAdaptee();
            var json = lumiaJSON.GetLumiaJSONSpecification();
            return JsonConvert.DeserializeXmlNode(json, "LumiaMobiles", true);
        }
    }
}
