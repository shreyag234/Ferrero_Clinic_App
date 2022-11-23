<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Appointments.aspx.cs" Inherits="Ferrero_Clinic_App.View_Appointments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:GridView ID="Appointment_Grid" runat="server" Width="300px" Height="200px"></asp:GridView>
        <table>
            <tr height="20dp"></tr>
            <tr>
                <td><asp:Button ID="Back_BTN" runat="server" Text="Back" Font-Bold="true" Font-Size="Larger" Width="100px" Style="float: right" OnClick="Back_BTN_Click"/></td>
            </tr>
        </table>
        
    </form>
</body>

</html>
