﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebScraper.Data
{
    public class ScrapeCriteria
    {

        public ScrapeCriteria()
        {
            parts = new List<ScrapeCriteriaPart>();
        }

        public string Data { get; set; }
        public string Regex { get; set; }
        public RegexOptions regexOptions { get; set; }
        public List<ScrapeCriteriaPart> parts { get; set; }


    }
}
