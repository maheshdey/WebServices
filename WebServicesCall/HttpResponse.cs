using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace WebServicesCall
{
    class HttpResponse
    {
        HttpWebResponse _webresponse;

        public HttpStatusCode _status
        {
            get { return _webresponse.StatusCode; }
        }

        public String messagebody
        {
            get
            {
                Encoding enc = System.Text.Encoding.GetEncoding(1252);
                StreamReader loResponseStream = new
                  StreamReader(_webresponse.GetResponseStream(), enc);

                string responsebody = loResponseStream.ReadToEnd();

                loResponseStream.Close();
                return responsebody;
            }
        }

        public HttpResponse(HttpWebResponse webresponse)
        {
            this._webresponse = webresponse;
        }


    }
}
