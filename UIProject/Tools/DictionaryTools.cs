using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProject.Tools
{
    class DictionaryTools
    {
        public static Dictionary<string, string> Dict1 { get; set; }
      
        public Dictionary<string, string> getDictionary(string key, string value)
        {
            Dict1 = new Dictionary<string, string>();
            Dict1.Add(key, value);
            return Dict1;
        }
    }
}
