using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp.Accounts
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateUser())
            {
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
            }
            else
            {
                Response.Write("Wrong login credentials.  Please try again.");
            }
        }

        private Boolean ValidateUser()
        {
            Boolean result = false;

            SqlConnection con;
            string cn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (con = new SqlConnection(cn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from Users", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["UserName"].ToString() == txtUsername.Text && dr["Password"].ToString() == txtPassword.Text)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }
    }
}