using System;
using YouaiSavior.util;

namespace YouaiSavior
{
    class XmlConfigInstance
    {
        private XmlConfigUtil xmlConfigUtil;

        private XmlConfigInstance() {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            xmlConfigUtil = new XmlConfigUtil(path  + "\\YouaiSavourConfig.xml");
        }
        private static XmlConfigInstance Instance { get; } = new XmlConfigInstance();
        public static XmlConfigUtil XML() {
            return Instance.xmlConfigUtil;
        }
    }
}
