<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="Ferrero_Clinic_App.Appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> 
        h1{text-align:center}
        .auto-style1 {
            float: right;
        }
        .auto-style2 {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-size:30px ">BOOK APPOINTMENTS</h1>
        </div>
         <table style="margin-left:auto;margin-right:auto;" >

             <tr height="20dp">
                 <td width="20dp">&nbsp;</td>
                <td class="auto-style2"><asp:Label ID="ID_LB" runat="server" Text="Patient ID: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="ID_tb" runat="server" width="200px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="IDvalidate" 
                         runat="server" ControlToValidate ="ID_tb"
                         ErrorMessage="Please provide patient ID" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
             </tr>
         <tr height="20dp">
              <td width="20dp">&nbsp;</td>
             <td class="auto-style2"><asp:Label ID="Date_LB" runat="server" Text="Date : " Font-Size="Larger" Width="100"></asp:Label></td>
                <td width="20dp"> <asp:Calendar ID="DatetoBook_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar></td>
             <td width="20dp">&nbsp;</td>
             <td width="20dp"><asp:Label ID="Time_LB" runat="server" Text="Time : " Font-Size="Larger" Width="100"></asp:Label></td>
              <td width="20dp"><span class="inner-datepicker">

                    <asp:DropDownList ID="Time_List" runat="server" Width="150" Height="40" Font-Size="Large">
                        <asp:ListItem>07:00</asp:ListItem>
<asp:ListItem>07:15</asp:ListItem>
<asp:ListItem>07:30</asp:ListItem>
<asp:ListItem>07:45</asp:ListItem>
<asp:ListItem>08:00</asp:ListItem>
<asp:ListItem>08:15</asp:ListItem>
<asp:ListItem>08:30</asp:ListItem>
<asp:ListItem>08:45</asp:ListItem>
<asp:ListItem>09:00</asp:ListItem>
<asp:ListItem>09:15</asp:ListItem>
<asp:ListItem>09:30</asp:ListItem>
<asp:ListItem>09:45</asp:ListItem>
<asp:ListItem>10:00</asp:ListItem>
<asp:ListItem>10:15</asp:ListItem>
<asp:ListItem>10:30</asp:ListItem>
<asp:ListItem>10:45</asp:ListItem>
<asp:ListItem>11:00</asp:ListItem>
<asp:ListItem>11:15</asp:ListItem>
<asp:ListItem>11:30</asp:ListItem>
<asp:ListItem>11:45</asp:ListItem>
<asp:ListItem>12:00</asp:ListItem>
<asp:ListItem>12:15</asp:ListItem>
<asp:ListItem>12:30</asp:ListItem>
<asp:ListItem>12:45</asp:ListItem>
<asp:ListItem>13:00</asp:ListItem>
<asp:ListItem>13:15</asp:ListItem>
<asp:ListItem>13:30</asp:ListItem>
<asp:ListItem>13:45</asp:ListItem>
<asp:ListItem>14:00</asp:ListItem>
<asp:ListItem>14:15</asp:ListItem>
<asp:ListItem>14:30</asp:ListItem>
<asp:ListItem>14:45</asp:ListItem>
<asp:ListItem>15:00</asp:ListItem>
<asp:ListItem>15:15</asp:ListItem>
<asp:ListItem>15:30</asp:ListItem>
<asp:ListItem>15:45</asp:ListItem>
<asp:ListItem>16:00</asp:ListItem>
<asp:ListItem>16:15</asp:ListItem>
<asp:ListItem>16:30</asp:ListItem>
<asp:ListItem>16:45</asp:ListItem>
                  </asp:DropDownList></span></td>
                
                
         </tr>
          <tr>
               <td width="20dp"></td>
               <td class="auto-style2">
                    <asp:Button ID="back_btn0" runat="server" Text="Back" Font-Bold="true" Font-Size="Large" Width="186px" CssClass="auto-style1" OnClick="back_btn0_Click"/></td>
               <td width="20dp">
                    <asp:Button ID="Add_btn" runat="server" Text="Book" Font-Bold="true" Font-Size="Large" Width="150px" Style="float: right" OnClick="Add_btn_Click"/></td>
                <td width="20dp"></td>
              
          </tr>  
         </table>
    </form>
</body>
</html>
