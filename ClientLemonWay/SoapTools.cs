using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClientLemonWay
{
    public static class SoapTools
    {
        public static Dictionary<string, object[]> ListWebMethod = new Dictionary<string,object[]>();

        public static void AddMethodSoap(string Name,params object[] param)
        {

            ListWebMethod.Add(Name, param);
           
        }


        public static XmlDocument GetEnvelopeSoap(string NameMethod,params object[] values)
        {
            XmlDocument doc = new XmlDocument();
            if (ListWebMethod.ContainsKey(NameMethod) && values.Length == ListWebMethod[NameMethod].Length)
            {
                
                doc.LoadXml(@"<?xml version='1.0' encoding='utf-8'?>
                            <soap12:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:soap12='http://www.w3.org/2003/05/soap-envelope'>
                              <soap12:Body>
                                
                              </soap12:Body>
                            </soap12:Envelope>");
                XmlNodeList te = doc.GetElementsByTagName("soap12:Body");

                XmlElement addf = doc.CreateElement(NameMethod);

                XmlAttribute addfAttr = doc.CreateAttribute("xmlns");
                addfAttr.Value = "http://tempuri.org/";
                addf.Attributes.Append(addfAttr);

               for(int i = 0; i < values.Length;i++)
                {
                    XmlElement itemTemp = doc.CreateElement(ListWebMethod[NameMethod][i].ToString());
                    itemTemp.InnerText = values[i].ToString();
                    addf.AppendChild(itemTemp);
                }
                if (te.Count > 0)
                    te[0].AppendChild(addf);
                else
                    Form1.log.Error("soap12:Body no find");

            }
            else
                Form1.log.Error("Methid Service : "+NameMethod+" no find");
            return doc;
        }
    }
}
