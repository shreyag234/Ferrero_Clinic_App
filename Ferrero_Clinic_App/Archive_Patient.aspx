<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Archive_Patient.aspx.cs" Inherits="Ferrero_Clinic_App.Archive_Patient" %>

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
             <h1 style="font-size:30px ">ARCHIVE PATIENTS</h1>
        </div>

        
     <table style="margin-left:auto;margin-right:auto;" >
          <tr height="20dp"></tr>
             <tr height="20dp">
                 <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Patient_LB" runat="server" Text="Patient ID: " Font-Size="Larger" Width="150"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Patient_tb" runat="server" width="250px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="Dvalidate" 
                         runat="server" ControlToValidate ="Patient_tb"
                         ErrorMessage="Please provide the diagnosis" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
             </tr>
         <tr height="20dp"></tr>
         <tr height="20dp">
             <td width="20dp">&nbsp;</td>
             <td width="20dp"><asp:Label ID="Status_LB" runat="server" Text="Are you sure you want to archive: " Font-Size="Larger" Width="250px"></asp:Label></td>
             <td widht="20dp">&nbsp;<asp:RadioButtonList ID="Confirm_rbn" runat="server" Font-Size="Larger">
                    <asp:ListItem ID="YEs_rbn" >Confirm</asp:ListItem>
                </asp:RadioButtonList></td>
                 <asp:RequiredFieldValidator ID="confirmValidate" 
                         runat="server" ControlToValidate ="Confirm_rbn"
                         ErrorMessage="Please select one" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>

         </tr>
          <tr height="20dp"></tr>
          <tr height="20dp">
              <td width="20dp">&nbsp;</td>
              <td width="20dp">&nbsp;</td>
              <td width="20dp"><asp:Button ID="Back_btn" runat="server" Text="Back" Width="100px" Font-Bold="true" Font-Size="Larger" CssClass="auto-style5" OnClick="Back_btn_Click"/></td></td>
              <td width="20dp"><asp:Button ID="Archive_btn" runat="server" Text="Archive" Width="150px" Font-Bold="true" Font-Size="Larger" CssClass="auto-style5" OnClick="Archive_btn_Click"/></td></td>
              <td width="20dp">&nbsp;</td>
              
          </tr>
     </table>
    </form>
</body>
</html>
