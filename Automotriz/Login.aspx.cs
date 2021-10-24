using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Automotriz
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-1DABGRU;initial catalog=carros;
Integrated Security=True;"))


            {


                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM usuario WHERE nombre=@username AND contrasena=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = txtUserName.Text.Trim();
                    //Response.Redirect("~/ Index.html");
                    Response.Redirect("~/Home/Index");


                }
                else { lblErrorMessage.Visible = true; }
            }

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}