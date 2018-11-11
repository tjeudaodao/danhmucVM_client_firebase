using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace danhmucVM_client
{
    class xulyJSON
    {
        public static JObject johts;
        public xulyJSON()
        {
            johts = JObject.Parse(File.ReadAllText("capnhat.json"));
        }
        // phan doc file cap nhat
        public string ReadJSON(string key)
        {
            return (string)johts[key];
        }
        public void UpdatevalueJSON(string key, string valuenew)
        {
            johts[key] = valuenew;
            string output = JsonConvert.SerializeObject(johts, Formatting.Indented);
            File.WriteAllText("capnhat.json", output);
        }
    }
}
