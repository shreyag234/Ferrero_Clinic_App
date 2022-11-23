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
    public partial class New_User : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");

        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Success Message", "alert('Admin login succesfully!');", true);
        }

        protected void Add_BTN_Click(object sender, EventArgs e)
        {
            if(Convert.ToString(User_Type_Selection_List01.SelectedItem).CompareTo("Administrator")==0)
            {
                byte[] p1, hash1;
                p1 = ASCIIEncoding.ASCII.GetBytes(Password_Box01.Text);
                hash1 = new MD5CryptoServiceProvider().ComputeHash(p1);
                byte[] p2, hash2;
                p2 = ASCIIEncoding.ASCII.GetBytes(Password_Box02.Text);
                hash2 = new MD5CryptoServiceProvider().ComputeHash(p2);
                bool check = false;
                
                if(hash1.Length == hash2.Length)
                {
                    int i = 0;
                    while((i< hash1.Length) && (hash1[i] == hash2[i]))
                    {
                        i++;
                    }
                    if(i==hash1.Length)
                    {
                        check = true;
                    }
                    
                }
                if(check)
                {
                    SqlCommand cmd = new SqlCommand("insert into [dbo].[Admin](Admin_Username, Password)values(@Admin_Username,@Password)", con);
                    cmd.Parameters.AddWithValue("@Admin_Username", Username_Box01.Text);
                    cmd.Parameters.AddWithValue("Password", hash1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User added sucessfully!');", true);
                }
                else
                {
                    matching_passwords_errorLB01.Visible = true;
                    matching_passwords_errorLB02.Visible = true;
                }
            }
            else if (Convert.ToString(User_Type_Selection_List01.SelectedItem).CompareTo("Medical Staff") == 0)
            {
                byte[] p1, hash1;
                p1 = ASCIIEncoding.ASCII.GetBytes(Password_Box01.Text);
                hash1 = new MD5CryptoServiceProvider().ComputeHash(p1);
                byte[] p2, hash2;
                p2 = ASCIIEncoding.ASCII.GetBytes(Password_Box02.Text);
                hash2 = new MD5CryptoServiceProvider().ComputeHash(p2);
                bool check = false;

                if (hash1.Length == hash2.Length)
                {
                    int i = 0;
                    while ((i < hash1.Length) && (hash1[i] == hash2[i]))
                    {
                        i++;
                    }
                    if (i == hash1.Length)
                    {
                        check = true;
                    }

                }
                if (check)
                {
                    SqlCommand cmd = new SqlCommand("insert into [dbo].[Med_Staff](Staff_ID, Password)values(@Staff_ID,@Password)", con);
                    cmd.Parameters.AddWithValue("@Staff_ID", Username_Box01.Text);
                    cmd.Parameters.AddWithValue("Password", hash1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User added succesfully!');", true);
                }
                else
                {
                    matching_passwords_errorLB01.Visible = true;
                    matching_passwords_errorLB02.Visible = true;
                }
            }
        }

        protected void Back_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}