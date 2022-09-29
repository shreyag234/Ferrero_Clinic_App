<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Patient.aspx.cs" Inherits="Ferrero_Clinic_App.Add_Patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    h1{text-align: center;}
</style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-size:20px ">PATIENT INFORMATION</h1>
        </div>
        
             <table >
            <tr height="20dp">
            </tr>
             <tr height="10dp">
            </tr>
            <tr height="30dp">
                <td width="20dp">&nbsp; </td>
                <td width="20dp"><asp:Label ID="Name_LB" runat="server" Text="Name: " Font-Size="Large" ></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Name_tb" runat="server"></asp:TextBox></td>

                <td width="20dp"><asp:Label ID="Surname_LB" runat="server" Text="Surname: " Font-Size="Large"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Surname_tb" runat="server" OnTextChanged="Surname_tb_TextChanged"></asp:TextBox></td>

                <td width="20dp"><asp:Label ID="Maiden_LB" runat="server" Text="Maiden: " Font-Size="Large"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Maiden_tb" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp; </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td width="100dp"></td>
                <td width="100dp"></td>
                <td>&nbsp; </td>
                <td>&nbsp;</td>
            </tr>
        <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
