using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cisco
{
    public partial class cisco_cert_form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                Response.Write("Hoşgeldin : " + Session["kullanıcı"]);
          
        
            
        }
    }
}