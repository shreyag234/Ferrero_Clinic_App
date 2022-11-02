using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
	public partial class Medical_History : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("insert into [dbo].[Med_History](Previous_Issues, Current_Medication, Dosage, Allergies, Major_Surgeries, Date_of_Surgery, Family_Med_History, Alcohol, Alcohol_Frequency, Smoking, " +
                "Smoking_Frequency, Illegal_Drugs, Patient_ID)" +
               "values(@Previous_Issues,@Current_Medication,@Dosage,@Allergies,@Major_Surgeries,@Date_of_Surgery,@Family_Med_History,@Alcohol,@Alcohol_Frequency,@Smoking,@Smoking_Frequency,@Illegal_Drugs,@Patient_ID)", con);

            cmd.Parameters.AddWithValue("@Previous_Issues" , PreviousProbs_tb.Text);
            cmd.Parameters.AddWithValue("@Current_Medication" ,CurrentMedication_tb.Text);
            cmd.Parameters.AddWithValue("@Dosage" ,Dosage_tb.Text);
            cmd.Parameters.AddWithValue("@Allergies", Allergies_tb.Text);
            cmd.Parameters.AddWithValue("@Major_Surgeries", MajorSurgeries_tb.Text);
            cmd.Parameters.AddWithValue("@Date_of_Surgery", SurgeryDate_cal.SelectedDate);
            cmd.Parameters.AddWithValue("@Family_Med_History", FamHistory_tb.Text);
            cmd.Parameters.AddWithValue("@Alcohol", Alcohol_rbn.SelectedValue);
            cmd.Parameters.AddWithValue("@Alcohol_Frequency", AlcoholYes_tb.Text);
            cmd.Parameters.AddWithValue("@Smoking", Smoke_rbn.SelectedValue);
            cmd.Parameters.AddWithValue("@Smoking_Frequency", SmokeYes_tb.Text);
            cmd.Parameters.AddWithValue("@Illegal_Drugs", Illegal_rbn.SelectedValue);
            cmd.Parameters.AddWithValue("@Patient_ID", pID_tb.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Medial history added sucessfully!');", true);

            Response.Redirect("DC_Dash_Board.aspx");

        }
	}
}