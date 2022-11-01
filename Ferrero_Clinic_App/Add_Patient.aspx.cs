using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class Add_Patient : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null)
            {
                HttpCookie cookieObj = Request.Cookies["userCookie"];
                string cookieObj2 = Request.Cookies["userCookie"].Value;
                string message = "alert('Login Successful! " + cookieObj2 + " , welcome!')";
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('No cookies :(');", true);
                Response.Redirect("index.aspx");

            }
        }


        protected void Next_btn_Click(object sender, EventArgs e)
        {
            string dob = ID_tb.Text.Substring(0, 6);
            if ((Convert.ToInt32(dob.Substring(0, 1)) == 0))
            {
                dob = "20" + dob.Substring(0, 2) + "-" + dob.Substring(2, 2) + "-" + dob.Substring(4, 2);

            }
            else
            {
                dob = "19" + dob.Substring(0, 2) + "-" + dob.Substring(2, 2) + "-" + dob.Substring(4, 2);

            }
            SqlCommand cmd = new SqlCommand("insert into [dbo].[Patients](Patient_ID, Patient_Name, Patient_Surname, Maiden_Name, Street, City, State, Zip, DOB, Phone, Email, Occupation," +
                " Employer, Marital_Status, Patient_Spouse_Name, Gender, Emg_Contact, Relation, Emg_Phone)" +
                "values(@Patient_ID,@Patient_Name,@Patient_Surname,@Maiden_Name,@Street,@City,@State,@Zip,@DOB,@Phone,@Email,@Occupation,@Employer,@Marital_Status,@Patient_Spouse_Name,@Gender,@Emg_Contact,@Relation,@Emg_Phone)", con);

            cmd.Parameters.AddWithValue("@Patient_ID", ID_tb.Text);
            cmd.Parameters.AddWithValue("@Patient_Name", Name_tb.Text);
            cmd.Parameters.AddWithValue("@Patient_Surname", Surname_tb.Text);
            cmd.Parameters.AddWithValue("@Maiden_Name", Maiden_tb.Text);
            cmd.Parameters.AddWithValue("@Street", Address_tb.Text);
            cmd.Parameters.AddWithValue("@City", City_tb.Text);
            cmd.Parameters.AddWithValue("@State", State_tb.Text);
            cmd.Parameters.AddWithValue("@Zip", Zip_tb.Text);
            cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(dob));
            cmd.Parameters.AddWithValue("@Phone", PhoneNum_tb.Text);
            cmd.Parameters.AddWithValue("@Email", Email_tb.Text);
            cmd.Parameters.AddWithValue("@Occupation", Occupation_tb.Text);
            cmd.Parameters.AddWithValue("@Employer", employer_tb.Text);
            cmd.Parameters.AddWithValue("@Marital_Status", StatusList_rbn.SelectedValue);
            cmd.Parameters.AddWithValue("@Patient_Spouse_Name", SpouseName_tb.Text);
            cmd.Parameters.AddWithValue("@Gender", RadioButtonList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Emg_Contact", EContact_tb.Text);
            cmd.Parameters.AddWithValue("@Relation", Relation_tb.Text);
            cmd.Parameters.AddWithValue("@Emg_Phone", EPhone_tb.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Details added sucessfully!');", true);
            
            string folderName = HttpContext.Current.Server.MapPath("~/Patients").ToString();
            string pathString = System.IO.Path.Combine(folderName, ID_tb.Text);
            System.IO.Directory.CreateDirectory(pathString);
            Response.Redirect("Medical_History.aspx");
        }


    }
}