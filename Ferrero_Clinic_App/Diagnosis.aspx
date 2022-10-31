<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diagnosis.aspx.cs" Inherits="Ferrero_Clinic_App.Diagnosis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> 
        h1{text-align:center}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1 style="font-size:30px ">PATIENT DIAGNOSIS</h1>
        </div>
        <table style="margin-left:auto;margin-right:auto;" >
         <tr height="20dp"></tr>
         <tr height="20dp">
              <td width="20dp">&nbsp;</td>
              <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Patient_ID" runat="server" Text="ID Number: " Font-Size="Larger" Width="100px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="patientID_tb" runat="server" width="200px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="IDvalidate" 
                         runat="server" ControlToValidate ="patientID_tb"
                         ErrorMessage="Please provide ID Number" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
         </tr>
         <tr height="20dp"></tr>
         <tr height="20dp">
             <td width="20dp">&nbsp;</td>
             <td width="20dp"><asp:Label ID="Diagnosis_LB" runat="server" Text="Diagnosis: " Font-Size="Larger" Width="100px"></asp:Label></td>
             <td width="20dp"><asp:TextBox ID="Diagnosis_tb" runat="server" width="200px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="diagnosisValidate" 
                         runat="server" ControlToValidate ="patientID_tb"
                         ErrorMessage="Please enter the diagnosis" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>

             <td width="20dp"><asp:Label ID="Date_LB" runat="server" Text="Pick the date: " Font-Size="Larger" Width="130px"></asp:Label></td>
             <td width="20dp"><asp:Calendar ID="DiagnosisDate_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar> </td>
              

         </tr>
        <tr height="20dp"></tr>
        <tr height="20dp">
            <td width="20dp">&nbsp;</td>
            <td><asp:Label ID="Mediaction_LB" runat="server" Text="Medication: " Font-Size="Larger" Width="130px"></asp:Label></td>
            <td width="20dp"><asp:TextBox ID="Medication_tb" runat="server" width="300px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="medicationValidate" 
                         runat="server" ControlToValidate ="Medication_tb"
                         ErrorMessage="Pelase enter medicication" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
        </tr>
            <tr height="20dp"></tr>
            <tr height="20dp">
                <td width="20dp">&nbsp;</td>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"></td>
                <td width="20dp">
                    <asp:Button ID="Next_btn" runat="server" Text="Next" Font-Bold="true" Font-Size="Larger" Width="150px" Style="float: right" OnClick="Next_btn_Click" /></td>
                <td width="20dp"></td>
                <td width="20dp"></td>
                
            </tr>
     </table>
    </form>
</body>
     
</html>
