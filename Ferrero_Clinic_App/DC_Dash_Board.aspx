<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DC_Dash_Board.aspx.cs" Inherits="Ferrero_Clinic_App.DC_Dash_Board" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 550px;
        }
        .auto-style4 {
            width: 309px;
        }
        .auto-style5 {
            width: 332px;
        }
        .auto-style6 {
            width: 445px;
        }
        .auto-style7 {
            width: 323px;
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
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="Add_Patient_BTN" runat="server" Text="Add A New Patient" Width="304px" OnClick="Add_Patient_BTN_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Veiw_Patient_BTN" runat="server" Text="Veiw Patient File" Width="291px" OnClick="Veiw_Patient_BTN_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Generate_Report_BTN" runat="server" Text="Generate A Report" OnClick="Generate_Report_BTN_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="View_Past_Reports" runat="server" Text="View Past Report" OnClick="View_Past_Reports_Click"/>
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Veiw_Calandar_BTN" runat="server" Text="Veiw Upcoming Apointments" Width="351px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
