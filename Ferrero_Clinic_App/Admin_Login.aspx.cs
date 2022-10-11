using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_BTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Password from Admin where Admin_Username='"+Username_Box1.Text+"'", con);
            con.Open();
            byte[] check = (byte[])cmd.ExecuteScalar();
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(Password_Box1.Text);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            if (check != null)
            {
                bool bEqual = false;
                if (tmpHash.Length == check.Length)
                {
                    int i = 0;
                    while ((i < tmpHash.Length) && (tmpHash[i] == check[i]))
                    {
                        i += 1;
                    }
                    if (i == tmpHash.Length)
                    {
                        bEqual = true;
                    }
                }
                if (bEqual)
                {
                    Response.Redirect("New_User.aspx");
                }
            }
        }
    }
}