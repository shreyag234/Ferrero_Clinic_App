using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies.Clear();
        }

        protected void Login_BTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Password from Med_Staff where Staff_ID='" + Username_Box.Text + "'", con);
            con.Open();
            byte[] check = (byte[])cmd.ExecuteScalar();
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(Password_Box.Text);
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
                    //creaitng a cookie 
                    HttpCookie userCookie = new HttpCookie("userCookie");
                    userCookie.Value = Username_Box.Text;
                    userCookie.Expires = DateTime.Now.AddHours(3);
                    Response.Cookies.Add(userCookie);
                    
                    Response.Redirect("DC_Dash_Board.aspx");
                }
            }
        
    }
    }
}