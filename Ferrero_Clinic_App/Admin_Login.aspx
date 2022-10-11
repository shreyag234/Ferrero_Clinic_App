<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Login.aspx.cs" Inherits="Ferrero_Clinic_App.Admin_Login" %>

<!DOCTYPE html>
<meta name="viewport" content="width=device-width", initial-scale ="1.0" />
<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 50px;
        }
        .auto-style3 {
            width: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    

    <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td width="200dp">&nbsp;</td>
                <td width="20dp">&nbsp;</td>
                <td width="150dp">&nbsp; <asp:Label ID="Heading_LB" runat="server" Text="ADMIN LOGIN " Font-Bold="true"></asp:Label></td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td width="100dp">&nbsp;</td>
                <td width="200dp">&nbsp; </td>
            </tr>
            <tr height="10dp">
                <td width="20dp">&nbsp;</td>
                <td width="20dp"></td>
                <td width="20dp"></td>
                <td width="20dp"></td>
                <td width="20dp" >&nbsp; <asp:Label ID="Username_LB1" runat="server" Text="Username " ></asp:Label></td>
                <td>&nbsp;<asp:TextBox ID="Username_Box1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp; </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td width="100dp"></td>
                <td width="100dp"></td>
                <td>&nbsp; <asp:Label ID="Password_LB2" runat="server" Text="Password " margin-bottom="20px"></asp:Label></td>
                <td>&nbsp;<asp:TextBox ID="Password_Box1" runat="server" TextMode="Password"></asp:TextBox></td>
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
                <td>&nbsp; <asp:Button ID="Login_BTN" runat="server" Text="Login" Width="147px" OnClick="Login_BTN_Click" /></td>
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
