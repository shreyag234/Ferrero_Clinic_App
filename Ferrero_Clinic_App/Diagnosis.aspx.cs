using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class Diagnosis : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null)
            {
                HttpCookie cookieObj = Request.Cookies["userCookie"];
                string cookieObj2 = Request.Cookies["userCookie"].Value;
                string message = "alert('Login Successful! " + cookieObj2 + " , welcome!')";
               // ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('No cookies :(');", true);
                Response.Redirect("index.aspx");

            }

        }

        protected void Next_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into [dbo].[Diagnosis](Patient_ID, Diagnosis, Date_of_diagnosis, Medication)" +
               "values(@Patient_ID,@Diagnosis,@Date_of_diagnosis,@Medication)", con);

            cmd.Parameters.AddWithValue("@Patient_ID", patientID_tb.Text);
            cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis_tb.Text);
            cmd.Parameters.AddWithValue("@Date_of_diagnosis", DiagnosisDate_cal.SelectedDate);
            cmd.Parameters.AddWithValue("@Medication", Medication_tb.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Patient diagnosis added!');", true);

            // Response.Redirect("DC_Dash_Board.aspx");
        }
    }
}