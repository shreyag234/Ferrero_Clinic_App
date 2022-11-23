using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;
using Paragraph = iText.Layout.Element.Paragraph;
using iText.Kernel.Colors;

namespace Ferrero_Clinic_App
{
    public partial class Archive_Patient : System.Web.UI.Page
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

        protected void Archive_btn_Click(object sender, EventArgs e)
        {
            if(Confirm_rbn.SelectedIndex == 0)
            {
                DataTable dt = GetData("SELECT * FROM Patients, Med_History WHERE Patients.Patient_ID = Med_History.Patient_ID AND Patients.Patient_ID = '" + Patient_tb.Text + "'");
                Document document = new Document(PageSize.A4, 88f, 88f, 10f, 10f);
                Font NormalFont = FontFactory.GetFont("Times New Roman", 12, Font.NORMAL, BaseColor.BLACK);

                using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
                    Phrase phrase = null;
                    PdfPCell cell = null;
                    PdfPTable table = null;
                    Color color = null;

                    document.Open();

                    //Header Table
                    table = new PdfPTable(2);
                    table.TotalWidth = 500f;
                    table.LockedWidth = true;
                    table.SetWidths(new float[] { 10f, 10f });

                    //Company Logo
                    iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(HttpContext.Current.Server.MapPath("~/Images/ferrero_logo.png"));
                    PdfPCell imageCell = new PdfPCell(png);
                    imageCell.Colspan = 2; // either 1 if you need to insert one cell
                    imageCell.Border = 0;
                    imageCell.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(imageCell);

                    //Company Name and Address
                    phrase = new Phrase();
                    Paragraph paragraph = new Paragraph();
                    phrase.Add(new Chunk("Ferrero\n\n", FontFactory.GetFont("Times New Roman", 16, Font.BOLD, BaseColor.ORANGE)));
                    phrase.Add(new Chunk("Walkerville,\n", FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)));
                    phrase.Add(new Chunk("177 Daleside Rd,\n", FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)));
                    phrase.Add(new Chunk("Gauteng, SA", FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)));
                    cell = PhraseCell(phrase, PdfPCell.ALIGN_CENTER);
                    cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
                    table.AddCell(cell);

                    //Separater Line
                    // color = new Color(System.Drawing.ColorTranslator.FromHtml("#A9A9A9"));
                    DrawLine(writer, 25f, document.Top - 79f, document.PageSize.Width - 25f, document.Top - 79f, BaseColor.LIGHT_GRAY);
                    DrawLine(writer, 25f, document.Top - 80f, document.PageSize.Width - 25f, document.Top - 80f, BaseColor.LIGHT_GRAY);
                    document.Add(table);

                    table = new PdfPTable(2);
                    table.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.SetWidths(new float[] { 0.3f, 1f });
                    table.SpacingBefore = 20f;

                    //Patient Details
                    cell = PhraseCell(new Phrase("Archived Patient Details", FontFactory.GetFont("Times New Roman", 12, Font.UNDERLINE, BaseColor.BLACK)), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    cell.PaddingBottom = 30f;
                    table.AddCell(cell);

                    foreach (DataRow dr in dt.Rows)
                    {
                        //Name
                        phrase = new Phrase();
                        // phrase.Add(new Chunk(dr["Diagnosis"].ToString(), FontFactory.GetFont("Times New Roman", 10, Font.BOLD, BaseColor.BLACK)));
                        phrase.Add(new Chunk("List of Archived Patients", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)));
                        cell = PhraseCell(phrase, PdfPCell.ALIGN_LEFT);
                        cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                        table.AddCell(cell);
                        document.Add(table);

                        DrawLine(writer, 160f, 80f, 160f, 690f, BaseColor.BLACK);
                        DrawLine(writer, 115f, document.Top - 200f, document.PageSize.Width - 100f, document.Top - 200f, BaseColor.BLACK);

                        table = new PdfPTable(2);
                        table.SetWidths(new float[] { 0.5f, 2f });
                        table.TotalWidth = 340f;
                        table.LockedWidth = true;
                        table.SpacingBefore = 20f;
                        table.HorizontalAlignment = Element.ALIGN_RIGHT;


                        //Patient Id
                        table.AddCell(PhraseCell(new Phrase("Patient ID:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Patient_ID"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Patient Name
                        table.AddCell(PhraseCell(new Phrase("Patient Name:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Patient_Name"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Patient Surname
                        table.AddCell(PhraseCell(new Phrase("Patient Surname:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Patient_Surname"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);


                        //Gender
                        table.AddCell(PhraseCell(new Phrase("Gender:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Gender"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Street address
                        table.AddCell(PhraseCell(new Phrase("Street and City:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Street"] + " " + dr["City"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //State
                        table.AddCell(PhraseCell(new Phrase("State:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["State"] + " " + dr["Zip"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Date of birth
                        table.AddCell(PhraseCell(new Phrase("Date of birth:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["DOB"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Contact details
                        table.AddCell(PhraseCell(new Phrase("Contact details:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Email"] + " " + dr["Phone"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Occupation
                        table.AddCell(PhraseCell(new Phrase("Occupation:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Occupation"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Employer
                        table.AddCell(PhraseCell(new Phrase("Employer:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Employer"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Marital Status
                        table.AddCell(PhraseCell(new Phrase("Marital Status:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Marital_Status"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Emergency Contact details 
                        table.AddCell(PhraseCell(new Phrase("Emergency Contact:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Emg_Contact"] + " " + dr["Relation"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Emergency phone num
                        table.AddCell(PhraseCell(new Phrase("Emgergency Number:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Emg_Phone"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Medical History:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Previous_Issues"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);

                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Current Medication:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Current_Medication"] + "Dosage" + dr["Dosage"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);
                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Allergies:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Allergies"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);
                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Major Surgeries:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Major_Surgeries"] +"Date: " + dr["Date_of_Surgery"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);
                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Family Medical History:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Family_Med_History"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);
                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Usage of Alcohol:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Alcohol"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);
                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Smoker (Yes/No) :", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Smoking"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);
                        //Patient's Medical history
                        table.AddCell(PhraseCell(new Phrase("Usage of Drugs:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        table.AddCell(PhraseCell(new Phrase("" + dr["Illegal_Drugs"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                        cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                        cell.Colspan = 2;
                        cell.PaddingBottom = 10f;
                        table.AddCell(cell);
                    }

                    document.Add(table);
                    document.Close();

                    byte[] bytes = memoryStream.ToArray();

                    System.IO.File.WriteAllBytes(HttpContext.Current.Server.MapPath("~/Patients/").ToString() + Patient_tb.Text + "/" + DateTime.Now.ToString("dd-MM-yyyy-HH") + "_Archived.pdf", bytes);
                    memoryStream.Close();
                    Response.Clear();
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("Content-Disposition", "attachment; filename=Archived.pdf");
                    Response.ContentType = "application/pdf";
                    Response.Buffer = true;
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.BinaryWrite(bytes);
                    Response.End();
                    Response.Close();


                }
            }

            SqlCommand cmd = new SqlCommand("DELETE * FROM Patients, Med_History WHERE Med_History.Patient_ID = Patients.Patient_ID AND Patients.Patient_ID = '" + Patient_tb.Text + "'");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }


        private DataTable GetData(string query)
        {

            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    adapter.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        private static void DrawLine(PdfWriter writer, float x1, float y1, float x2, float y2, BaseColor c)
        {
            PdfContentByte contentByte = writer.DirectContent;
            contentByte.SetColorStroke(c);
            contentByte.MoveTo(x1, y1);
            contentByte.LineTo(x2, y2);
            contentByte.Stroke();
        }
        private static PdfPCell PhraseCell(Phrase phrase, int align)
        {
            PdfPCell cell = new PdfPCell(phrase);
            cell.BorderColor = BaseColor.WHITE;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 2f;
            cell.PaddingTop = 0f;
            return cell;
        }
        protected void Back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("DC_Dash_Board.aspx");
        }
    }
}