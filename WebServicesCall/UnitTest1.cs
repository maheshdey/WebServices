using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServicesCall
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HttpRequest t = new HttpRequest("/maps/api/geocode/json?address=Pune&sensor=true");
            HttpResponse r = t.getResponse();
            Console.WriteLine(r._status);
            Console.WriteLine(r.messagebody);
        }

    }
}
