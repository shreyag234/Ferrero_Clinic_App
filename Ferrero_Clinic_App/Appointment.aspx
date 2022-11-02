<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="Ferrero_Clinic_App.Appointment" %>

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
            <h1 style="font-size:30px ">BOOK APPOINTMENTS</h1>
        </div>
         <table style="margin-left:auto;margin-right:auto;" >

             <tr height="20dp"></tr>
             <tr height="20dp">
                 <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="ID_LB" runat="server" Text="Patient ID: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="ID_tb" runat="server" width="200px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="IDvalidate" 
                         runat="server" ControlToValidate ="ID_tb"
                         ErrorMessage="Please provide patient ID" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
             </tr>
         <tr height="20dp"></tr>
         <tr height="20dp">
              <td width="20dp">&nbsp;</td>
             <td width="20dp"><asp:Label ID="Date_LB" runat="server" Text="Date : " Font-Size="Larger" Width="100"></asp:Label></td>
                <td width="20dp"> <asp:Calendar ID="DatetoBook_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar></td>
             <td width="20dp">&nbsp;</td>
             <td width="20dp"><asp:Label ID="Time_LB" runat="server" Text="Time : " Font-Size="Larger" Width="100"></asp:Label></td>
              <td width="20dp"><span class="inner-datepicker">

                    <asp:DropDownList ID="Time_List" runat="server" Width="150" Height="40" Font-Size="Large"></asp:DropDownList></span></td>
                
                
         </tr>
        <tr height="30dp"></tr>
          <tr height="20dp">
               <td width="20dp">&nbsp;</td>
               <td width="20dp">&nbsp;</td>
               <td width="20dp">
                    <asp:Button ID="Add_btn" runat="server" Text="Book" Font-Bold="true" Font-Size="Large" Width="150px" Style="float: right" OnClick="Add_btn_Click"/></td>
                <td width="20dp"></td>
              
          </tr>  
         </table>
    </form>
</body>
</html>
