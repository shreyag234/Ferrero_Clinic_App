<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Reports.aspx.cs" Inherits="Ferrero_Clinic_App.View_Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvDetails" CellPadding="5" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" CssClass="auto-style12">
                        <Columns>
                        <asp:BoundField DataField="Text" HeaderText="Patient Documents" />

                            <asp:ButtonField Text="Download" />

                        </Columns>
                        <HeaderStyle BackColor="#df5015" Font-Bold="true" ForeColor="White" />
                        </asp:GridView>
        </div>
    </form>
</body>
</html>
