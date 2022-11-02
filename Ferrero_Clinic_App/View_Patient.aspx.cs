using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{

    public partial class View_Patient : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");
        List<ListItem> files = new List<ListItem>();
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
            Update_BTN01.Visible = false;
        }

        protected void Search_BTN_01_Click(object sender, EventArgs e)
        {
            string test = ID_Number_TB01.Text.ToString();
            test_box.Text = test;
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patients WHERE Patient_ID='" + ID_Number_TB01.Text + "'", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                PF_Name_LB01.Visible = true;
                PF_Name_TB01.Visible = true;
                PF_Name_TB01.Text = rdr["Patient_Name"].ToString();
                PS_Name_LB01.Visible = true;
                PS_Name_TB01.Visible = true;
                PS_Name_TB01.Text = rdr["Patient_Surname"].ToString();
                P_DOB_LB01.Visible = true;
                P_DOB_TB01.Visible = true;
                P_DOB_TB01.Text = rdr["DOB"].ToString().Substring(0, 10);
                P_Add_LB01.Visible = true;
                P_Add_TB01.Visible = true;
                P_Add_TB01.Text = rdr["Street"].ToString();
                P_City_LB01.Visible = true;
                P_City_TB01.Visible = true;
                P_City_TB01.Text = rdr["City"].ToString();
                P_State_LB01.Visible = true;
                P_State_TB01.Visible = true;
                P_State_TB01.Text = rdr["State"].ToString();
                P_ZIP_LB01.Visible = true;
                P_ZIP_TB01.Visible = true;
                P_ZIP_TB01.Text = rdr["Zip"].ToString();
                P_Phone_LB01.Visible = true;
                P_Phone_TB01.Visible = true;
                P_Phone_TB01.Text = rdr["Phone"].ToString();
                P_Email_LB01.Visible = true;
                P_Email_TB01.Visible = true;
                P_Email_TB01.Text = rdr["Email"].ToString();
                P_Occupation_LB01.Visible = true;
                P_Occupation_TB01.Visible = true;
                P_Occupation_TB01.Text = rdr["Occupation"].ToString();
                P_Employer_LB01.Visible = true;
                P_Employer_TB01.Visible = true;
                P_Employer_TB01.Text = rdr["Employer"].ToString();
                P_M_Stat_LB01.Visible = true;
                P_M_Stat_TB01.Visible = true;
                P_M_Stat_TB01.Text = rdr["Marital_Status"].ToString();
                P_SP_F_Name_LB01.Visible = true;
                P_SP_F_Name_TB01.Visible = true;
                P_SP_F_Name_TB01.Text = rdr["Patient_Spouse_Name"].ToString();
                P_Gender_LB01.Visible = true;
                P_Gender_TB01.Visible = true;
                P_Gender_TB01.Text = rdr["Gender"].ToString();
                P_E_Cont_LB01.Visible = true;
                P_E_Cont_TB01.Visible = true;
                P_E_Cont_TB01.Text = rdr["Emg_Contact"].ToString();
                P_Relation_LB01.Visible = true;
                P_Relation_TB01.Visible = true;
                P_Relation_TB01.Text = rdr["Relation"].ToString();
                P_E_Cont_Phone_LB01.Visible = true;
                P_E_Cont_Phone_TB01.Visible = true;
                P_E_Cont_Phone_TB01.Text = rdr["Emg_Phone"].ToString();
                PM_Name_LB01.Visible = true;
                PM_Name_TB01.Visible = true;
                PM_Name_TB01.Text = rdr["Maiden_Name"].ToString();

                string[] filesPath = Directory.GetFiles(HttpContext.Current.Server.MapPath("~/Patients/").ToString() + ID_Number_TB01.Text);
                
                foreach (string path in filesPath)
                {
                    files.Add(new ListItem(Path.GetFileName(path)));
                }
                gvDetails.DataSource = files;
                
                gvDetails.DataBind();
            }


        }

        

        
        protected void Update_BTN01_Click(object sender, EventArgs e)
        {

            string dob = ID_Number_TB01.Text.Substring(0, 6);
            if ((Convert.ToInt32(dob.Substring(0, 1)) == 0))
            {
                dob = "20" + dob.Substring(0, 2) + "-" + dob.Substring(2, 2) + "-" + dob.Substring(4, 2);

            }
            else
            {
                dob = "19" + dob.Substring(0, 2) + "-" + dob.Substring(2, 2) + "-" + dob.Substring(4, 2);

            }
            SqlCommand cmd = new SqlCommand("UPDATE Patients SET Patient_ID = @Patient_ID , Patient_Name = @Patient_Name, Patient_Surname = @Patient_Surname, Maiden_Name = @Maiden_Name, Street = @Street, City = @City, State = @State, Zip = @Zip,DOB = @DOB, Phone = @Phone, Email = @Email, Occupation = @Occupation," +
                " Employer = @Employer, Marital_Status = @Marital_Status, Patient_Spouse_Name = @Patient_Spouse_Name, Gender = @Gender, Emg_Contact = @Emg_Contact, Relation = @Relation, Emg_Phone = @Emg_Phone WHERE Patient_ID = '" + test_box.Text + "'", con);

            cmd.Parameters.AddWithValue("@Patient_ID", ID_Number_TB01.Text);
            cmd.Parameters.AddWithValue("@Patient_Name", PF_Name_TB01.Text);
            cmd.Parameters.AddWithValue("@Patient_Surname", PS_Name_TB01.Text);
            cmd.Parameters.AddWithValue("@Maiden_Name", PM_Name_TB01.Text);
            cmd.Parameters.AddWithValue("@Street", P_Add_TB01.Text);
            cmd.Parameters.AddWithValue("@City", P_City_TB01.Text);
            cmd.Parameters.AddWithValue("@State", P_State_TB01.Text);
            cmd.Parameters.AddWithValue("@Zip", P_ZIP_TB01.Text);
            cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(dob));
            cmd.Parameters.AddWithValue("@Phone", P_Phone_TB01.Text);
            cmd.Parameters.AddWithValue("@Email", P_Email_TB01.Text);
            cmd.Parameters.AddWithValue("@Occupation", P_Occupation_TB01.Text);
            cmd.Parameters.AddWithValue("@Employer", P_Employer_TB01.Text);
            cmd.Parameters.AddWithValue("@Marital_Status", P_M_Stat_TB01.Text);
            cmd.Parameters.AddWithValue("@Patient_Spouse_Name", P_SP_F_Name_TB01.Text);
            cmd.Parameters.AddWithValue("@Gender", P_Gender_TB01.Text);
            cmd.Parameters.AddWithValue("@Emg_Contact", P_E_Cont_Phone_TB01.Text);
            cmd.Parameters.AddWithValue("@Relation", P_Relation_TB01.Text);
            cmd.Parameters.AddWithValue("@Emg_Phone", P_E_Cont_Phone_TB01.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Details added sucessfully!');", true);
            Search_BTN_01_Click(sender, e);
        }

        protected void TextChanged(object sender, EventArgs e)
        {
            Update_BTN01.Visible = true;
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            string id = (string)e.CommandArgument;

            string x = gvDetails.Rows[Convert.ToInt32(id)].Cells[0].Text;
          

            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename="+x);
            Response.TransmitFile(HttpContext.Current.Server.MapPath("~/Patients/").ToString()+ID_Number_TB01.Text+"/"+x);
            Response.End();

        }

        protected void UploadBtn_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {

                FileUpload1.SaveAs(HttpContext.Current.Server.MapPath("~/Patients/").ToString() + ID_Number_TB01.Text + "/" + FileUpload1.FileName);
                
            }
            else
            {
               
            }
            string[] filesPath = Directory.GetFiles(HttpContext.Current.Server.MapPath("~/Patients/").ToString() + ID_Number_TB01.Text);

            foreach (string path in filesPath)
            {
                files.Add(new ListItem(Path.GetFileName(path)));
            }
            gvDetails.DataSource = files;

            gvDetails.DataBind();
        }

    }
}

