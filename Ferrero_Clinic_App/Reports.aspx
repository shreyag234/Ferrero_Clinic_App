<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Ferrero_Clinic_App.Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>

    </title>
     <style> 
        h1{text-align:center}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1 style="font-size:30px ">GENERATE REPORTS</h1>
        </div>
   
     <table style="margin-left:auto;margin-right:auto;" >
         <tr height="20dp"></tr>
             <tr height="20dp">
                 <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Daignosis_LB" runat="server" Text="Diagnosis: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Diagnosis_tb" runat="server" width="200px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="Dvalidate" 
                         runat="server" ControlToValidate ="Diagnosis_tb"
                         ErrorMessage="Please provide the diagnosis" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
             </tr>
         <tr height="20dp"></tr>
&nbsp;</td>
                <td width="20dp"><asp:Label ID="Daterange_LB" runat="server" Text="Date Range: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"> <asp:Calendar ID="StartDate_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar></td>
                <td width="20dp"></td>
                <td width="20dp"> <asp:Calendar ID="EndDate_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar></td>
               
             </tr>
         <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Button ID="Back_BTN" runat="server" Text="Back" Font-Bold="true" Font-Size="Larger" Width="150px" Style="float: right" OnClick="Back_BTN_Click"/></td>
                <td width="20dp"></td>
                <td width="20dp">
                    <asp:Button ID="Gen_btn" runat="server" Text="Generate" Font-Bold="true" Font-Size="Larger" Width="150px" Style="float: right" OnClick="Gen_btn_Click"/></td>
                <td width="20dp"></td>
                <td width="20dp"></td>
                
            </tr>
            </table>
         </form>
</body>
</html>
