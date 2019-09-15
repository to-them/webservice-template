using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice_template
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private string _firstname { get; set; }
        private string _lastname { get; set; }
        private double _firstnumber { get; set; }
        private double _secondnumber { get; set; }

        [WebMethod]
        public string HelloWorld(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
            
            return "Hello World ! Your full name is: " + _firstname + " " + _lastname;
        }

        [WebMethod]
        public double Add(double x, double y)
        {
            _firstnumber = x;
            _secondnumber = y;
            
            return _firstnumber + _secondnumber;
        }
        
    }
}
