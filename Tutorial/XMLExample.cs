﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tutorial
{
    [Serializable]
    [XmlRoot("Root")]
    public class XMLExample
    {
        [XmlAttribute]
        public string Email { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Age")]
        public int Age { get; set; }
    }
}
