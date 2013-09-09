using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace WebServicesCall
{
    class HttpRequest
    {
        HttpWebRequest _webrequest = null;
        String _baseURI = "http://maps.googleapis.com";
        String _path = null;
        public HttpRequest(String path)
        {
          this._webrequest = (HttpWebRequest)WebRequest.Create(_baseURI + path);
          _path = path;
        }

        public HttpResponse getResponse()
        {
            return new HttpResponse((HttpWebResponse)_webrequest.GetResponse());
        }




    }
}
