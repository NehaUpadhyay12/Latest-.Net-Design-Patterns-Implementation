using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class LumiaJSONAdaptee
    {
        public string GetLumiaJSONSpecification()
        {
            List<LumiaMobile> lumiaMobiles = new List<LumiaMobile>();
            lumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "lumia550",
                Height = "136.11 mm",
                Width = "67.8 mm",
                Thickness = "9.9 mm",
                Weight = "141.9 gm"
            });
            lumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "lumia950",
                Height = "146.11 mm",
                Width = "70.8 mm",
                Thickness = "10.9 mm",
                Weight = "156.9 gm"
            });
            lumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "lumia750",
                Height = "130.11 mm",
                Width = "57.8 mm",
                Thickness = "8.9 mm",
                Weight = "136.9 gm"
            });

            dynamic collectionMobiles = new { lm = lumiaMobiles };
            return JsonConvert.SerializeObject(collectionMobiles);
        }
    }
}
