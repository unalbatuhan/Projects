using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Cisco
{
    public partial class cisco_cert_form : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssqlservers.database.windows.net;Initial Catalog=StartsHere_DB;Integrated Security=False;User ID=batuhan;Password=Batu@1741034;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;");
            con.Open();
            string name = txtName.Text;
            string mail = txtMail.Text;
            SqlCommand com = new SqlCommand("Select * from ProviderTable Where User_Name = '"+name+"' and User_Mail = '"+mail+"'", con);
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {
                Session.Add("kullanıcı", name);
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text="Giriş Başarısız.";
            }
                

        }
    }
}