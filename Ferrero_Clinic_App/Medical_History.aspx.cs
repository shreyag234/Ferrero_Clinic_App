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

		}

		protected void Next_btn_Click(object sender, EventArgs e)
		{
            SqlCommand cmd = new SqlCommand("insert into [dbo].[Med_History](Previous_Issues, Current_Medication, Allergies, Medical_Procedures, Family_Med_History, Alcohol, Alcohol_Frequency, Smoking, " +
                "Smoking_Frequency, Illegal_Drugs, Patient_ID)" +
               "values(@Previous_Issues,@Current_Medication,@Allergies,@Medical_Procedures,@Family_Med_History,@Alcohol,@Alcohol_Frequency,@Smoking,@Smoking_Frequency,@Illegal_Drugs,@Patient_ID)", con);

            cmd.Parameters.AddWithValue("@Previous_Issues" , PreviousProbs_tb.Text);
            cmd.Parameters.AddWithValue("@Current_Medication" ,CurrentMedication_tb.Text);
            cmd.Parameters.AddWithValue("@Allergies", Allergies_tb.Text);
           // cmd.Parameters.AddWithValue("@Medical_Procedures", );

              //  "Family_Med_History, Alcohol, Alcohol_Frequency, Smoking, \""Smoking_Frequency, Illegal_Drugs, Patient_ID

            //okie
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Details added sucessfully!');", true);

            Response.Redirect("DashBoard.aspx");

        }
	}
}