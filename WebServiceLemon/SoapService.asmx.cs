using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

namespace WebServiceLemon
{
    /// <summary>
    /// Description résumée de SoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapService : System.Web.Services.WebService
    {


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int Fibonacci(int n)
        {
            Thread.Sleep(5000);

            try
            {
                if (1 > n || n > 100)
                    return -1;

                int a = 0;
                int b = 1;

                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return a;
            }
            catch
            {
                return -1;
            }
            
        }

     
        [WebMethod]
        public string XmlToJson(string xml)
        {
            string jsonText;
            XmlDocument doc = new XmlDocument();
            try
            {
                XElement xd = XElement.Parse(xml);
                xd.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
                xd.Descendants().Attributes().Remove();
                doc.LoadXml(xd.ToString());

                jsonText = JsonConvert.SerializeXmlNode(doc);
            }
            catch (Exception ex)
            {
                return "Bad Xml format";
            }
            return jsonText;
        }
    }
}
