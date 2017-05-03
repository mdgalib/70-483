using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
namespace _1._1
{
    class Program4
    {
        public static void Main(string[] args)
        {
            var _url = "http://www.morphisinc.net/Mwebservice/CashForecast.asmx";
            var _action = "\"http://tempuri.org/" + "StoreSmartSafeData" + "\"";
            string s = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                <soap:Body>
                <StoreSmartSafeData xmlns=""http://tempuri.org/"">
                    <userID>asdf</userID>
                    <password>asdfddddddd</password>
                    <data>striasdfng</data>
                    <ipAddress>strasdfinffffffffffffffg</ipAddress>
                    </StoreSmartSafeData>
                </soap:Body>
            </soap:Envelope>";

            Test1.HttpPostData(_url, s, "text/xml;charset=\"utf-8\"", new string[] { "SOAPAction:" + _action }, null);

            Test1.HttpPostData(_url, s, "text/xml;charset=\"utf-8\"", new string[] { "SOAPAction:" + _action }, null);

            //This is feature 1 
            //this is master

        }
       
    }
}
