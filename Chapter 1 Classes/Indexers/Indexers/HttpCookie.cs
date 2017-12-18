using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class HttpCookie
    {

        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        //or Dictionary<string, string> _dictionary = new Dictionary<string,string>();

        public HttpCookie()
        {

            _dictionary = new Dictionary<string,string>();

        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set { _dictionary[key] = value; }

        }

        //if we didn't have indexers we would have to write
        public void SetItem(string key, string value)
        {

        }


        public string GetiItem(string key)
        {
            return key;
        }





    }
}
