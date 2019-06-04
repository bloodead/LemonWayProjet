using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClientLemonWay
{

    public enum TypeHttp
    {
        Post = 0,
        Get = 1
    }
    public class WebRequester
    {
        private string WebServiceUri;
        private HttpWebRequest CurrentRequest;
        public WebRequester(string webServiceUri)
        {
            WebServiceUri = webServiceUri;
            
        }

        public string Request(string NameWebMethod, TypeHttp typeHttp = TypeHttp.Post, params object[] values)
        {
            string Result = "Error Request";


            CurrentRequest = (HttpWebRequest)HttpWebRequest.Create(WebServiceUri);
            if (typeHttp == TypeHttp.Post)
                CurrentRequest.Method = "POST";
            else
                CurrentRequest.Method = "GET";
            CurrentRequest.ContentType = "text/xml;charset=\"utf-8\"";
            CurrentRequest.Headers.Add(WebServiceUri + "/" + NameWebMethod);
            CurrentRequest.Accept = "text/xml";
            XmlDocument SOAPReqBody = SoapTools.GetEnvelopeSoap(NameWebMethod,values);
            //Debug Evenloppe SOAP
           // MessageBox.Show(SOAPReqBody.OuterXml);
            using (Stream writer = CurrentRequest.GetRequestStream())
            {


                SOAPReqBody.Save(writer);



                HttpWebResponse reponse = (HttpWebResponse)CurrentRequest.GetResponse();
                   StreamReader Reader = new StreamReader(reponse.GetResponseStream());

                   Result = Reader.ReadToEnd();
            }

                
                return Result.SoapResult(NameWebMethod);
        }

        private void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}
