using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;


namespace Logging
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int a=7;
                int b= 0;
                int c = a/b;
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex, "LoggingPolicy");
            }
        }
    }
}