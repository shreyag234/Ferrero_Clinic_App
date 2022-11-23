<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New_User.aspx.cs" Inherits="Ferrero_Clinic_App.New_User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 276px;
        }
        .auto-style3 {
            width: 248px;
        }
        .auto-style4 {
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="User_Type_LB" runat="server" Text="User Type :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="User_Type_Selection_List01" runat="server">
                        <asp:ListItem>Administrator</asp:ListItem>
                        <asp:ListItem>Medical Staff</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Username_lb" runat="server" Text="Username :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="Username_Box01" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Password_LB1" runat="server" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="Password_Box01" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="matching_passwords_errorLB01" runat="server" ForeColor="#CC0000" Text="Passwords do not match" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Password_LB2" runat="server" Text="Re-enter Password :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="Password_Box02" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="matching_passwords_errorLB02" runat="server" ForeColor="#CC0000" Text="Passwords do not match" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Back_BTN" runat="server" Text="Log Out" Width="202px" OnClick="Back_BTN_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Add_BTN" runat="server" Text="Add" Width="173px" OnClick="Add_BTN_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
