﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class HttpCookie
    {

        private Dictionary<string, string> _dictionary;

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





    }
}
