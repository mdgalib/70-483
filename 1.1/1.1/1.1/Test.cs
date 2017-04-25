using System;
using System.IO;
using System.Net;
using System.Text;

namespace _1._1
{
    public static class Test1
    {
        public static void HttpPostData(string Url, object Content, string ContentType,
            string[] HttpHeaders = null, string OutputFile = null)
        {
            WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create(Url);

            rq.KeepAlive = false;
            rq.Timeout = 120 * 1000;
            rq.ReadWriteTimeout = 120 * 1000;
            rq.UseDefaultCredentials = true;
            rq.Method = WebRequestMethods.Http.Post;

            rq.ContentType = ContentType;
            int n = HttpHeaders.Length;
            for (int i = 0; i < n; i++) { rq.Headers.Add(HttpHeaders[i]); }

            byte[] data = Encoding.UTF8.GetBytes(Content as string);
            rq.ContentLength = data.Length;

            using (Stream s = rq.GetRequestStream())
            {
                s.Write(data, 0, data.Length);
            }

            string output = "";

            try
            {
                using (HttpWebResponse rs = (HttpWebResponse)rq.GetResponse())
                {
                    using (Stream s = rs.GetResponseStream())
                    {
                        using (StreamReader r = new StreamReader(s))
                        {
                            output = r.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); ;
            }

        }

    }

}
