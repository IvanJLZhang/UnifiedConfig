﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml.XPath;

namespace ConfigUtilty
{
    internal class XmlConigManager : XmlConfig
    {

        public XmlConigManager(string filepath)
            :base(filepath, XDocument.Load(filepath))
        {

        }

        public override void Save(string filepath = null)
        {
            File.WriteAllText(filepath ?? _sourceFilePath, _root.ToIni());
        }
    }
}
