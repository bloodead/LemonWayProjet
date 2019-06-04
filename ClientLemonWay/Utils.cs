using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClientLemonWay
{
    public static class Utils
    {

        public static XmlDocument ToXmlDocument(this string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(value);

            return doc;
        }

        public static string SoapResult(this string value,string NameMethodSoap)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(value);

            XmlNodeList re = doc.GetElementsByTagName(NameMethodSoap + "Result");

            return re[0].InnerText;
        }

       
    }
}
