<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Patient.aspx.cs" Inherits="Ferrero_Clinic_App.View_Patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 377px;
        }
        .auto-style2 {
            width: 279px;
        }
        .auto-style3 {
            width: 314px;
        }
        .auto-style4 {
            width: 210px;
        }
        .auto-style5 {
            width: 128px;
        }
        .auto-style8 {
            width: 279px;
            height: 70px;
        }
        .auto-style9 {
            width: 314px;
            height: 70px;
        }
        .auto-style10 {
            width: 210px;
            height: 70px;
        }
        .auto-style11 {
            width: 128px;
            height: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Please_Enter_LB01" runat="server" Text="Enter Patient ID Number:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="ID_Number_TB01" runat="server" Width="156px" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td rowspan="13">
                  
                        <asp:GridView ID="gvDetails" CellPadding="5" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                        <asp:BoundField DataField="Text" HeaderText="Patient Documents" />

                            <asp:ButtonField Text="Download" />

                        </Columns>
                        <HeaderStyle BackColor="#df5015" Font-Bold="true" ForeColor="White" />
                        </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="PF_Name_LB01" runat="server" Text="Patient Name:" Visible="false"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="PF_Name_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_Phone_LB01" runat="server" Text="Patient Phone:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_Phone_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="PS_Name_LB01" runat="server" Text="Patient Surname Name:" Visible="false"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="PS_Name_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_Email_LB01" runat="server" Text="Patient Email:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_Email_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="P_DOB_LB01" runat="server" Text="Patient Date Of Birth:" Visible="false"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="P_DOB_TB01" runat="server" Width="156px" Visible="false" ReadOnly="true"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_Occupation_LB01" runat="server" Text="Patient Occupation:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_Occupation_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="P_Add_LB01" runat="server" Text="Patient Address:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="P_Add_TB01" runat="server" Width="256px" Visible="false" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_Employer_LB01" runat="server" Text="Patient Employer:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_Employer_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="P_City_LB01" runat="server" Text="Patient City:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="P_City_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_M_Stat_LB01" runat="server" Text="Patient Maritual Status:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_M_Stat_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="P_State_LB01" runat="server" Text="Patient State:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="P_State_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_SP_F_Name_LB01" runat="server" Text="Patient Spouse Fullname:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_SP_F_Name_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="P_ZIP_LB01" runat="server" Text="Patient ZIP:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="P_ZIP_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_Gender_LB01" runat="server" Text="Patient Gender:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_Gender_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="PM_Name_LB01" runat="server" Text="Patient Maiden Name:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="PM_Name_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="P_E_Cont_LB01" runat="server" Text="Patient Emergency Contact:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="P_E_Cont_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="P_E_Cont_Phone_LB01" runat="server" Text="Emergency Contact Phone:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="P_E_Cont_Phone_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="P_Relation_LB01" runat="server" Text="Relation:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="P_Relation_TB01" runat="server" Width="156px" Visible="false" OnTextChanged="TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="test_box" runat="server" Visible ="false" Width="23px"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Search_BTN_01" runat="server" Text="Search" Width="129px" OnClick="Search_BTN_01_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Update_BTN01" runat="server" Text="Update" OnClick="Update_BTN01_Click"/>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>