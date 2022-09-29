﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Patient.aspx.cs" Inherits="Ferrero_Clinic_App.Add_Patient" %>

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
            <h1 style="font-size:30px ">PATIENT INFORMATION</h1>
        </div>
        
             <table style="margin-left:auto;margin-right:auto;" >
            <tr height="20dp">
            </tr>
             <tr height="10dp">
            </tr>
            <tr height="30dp">
                <td width="20dp">&nbsp; </td>
                <td width="20dp"><asp:Label ID="Name_LB" runat="server" Text="Name: " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Name_tb" runat="server"></asp:TextBox></td>

                <td width="20dp"><asp:Label ID="Surname_LB" runat="server" Text="Surname: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Surname_tb" runat="server" OnTextChanged="Surname_tb_TextChanged"></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Maiden_LB" runat="server" Text="Maiden: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Maiden_tb" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr height="10dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Address_LB" runat="server" Text="Address:  " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Address_tb" runat="server" width="280px"></asp:TextBox> </td>
                <td width="20dp">
                    <asp:Label ID="City_LB" runat="server" Text="City: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="City_tb" runat="server"></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="State_LB" runat="server" Text="State: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp">
                    <asp:TextBox ID="State_tb" runat="server" ></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                <td width="20dp">
                    <asp:Label ID="Zip_LB" runat="server" Text="Zip: " Font-Size="Larger"></asp:Label> </td>
                <td width="20dp">
                    <asp:TextBox ID="Zio_tb" runat="server" Width="80px"></asp:TextBox></td>
            </tr>
            <tr height="10dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="DOB_LB" runat="server" Text="DOB:  " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="DOB_tb" runat="server"></asp:TextBox> </td>
                <td width="20dp">
                    <asp:Label ID="Phone_LB" runat="server" Text="Phone: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="PhoneNum_tb" runat="server"></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                
            </tr>
        <tr height="10dp"></tr>
        <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Email_LB" runat="server" Text="Email:  " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Eamil_tb" runat="server" width="250px"></asp:TextBox> </td>
                <td width="20dp">
                    <asp:Label ID="Occupation_LB" runat="server" Text="Occupation: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Occupation_tb" runat="server"></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Employer_LB" runat="server" Text="Employer: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp">
                    <asp:TextBox ID="employer_tb" runat="server" ></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                
            </tr>
            <tr height="10dp"></tr>
            <tr>
                <td widht="20dp"></td>
                <td width="20dp"><asp:Label ID="Status_LB" runat="server" Text="Marital Status: " Font-Size="Larger" Width="150px"></asp:Label></td>
                <td widht="20dp">&nbsp;<asp:RadioButtonList ID="StatusList_rbn" runat="server" Font-Size="Larger">
                    <asp:ListItem ID="Married_rbn" >Married</asp:ListItem>
                    <asp:ListItem Id="Unmarried_rbn">Unmarried</asp:ListItem>
                    <asp:ListItem ID="Divorced_rbn">Divorced</asp:ListItem>
                    <asp:ListItem ID="Widowed_rbn">Widowed</asp:ListItem>
                </asp:RadioButtonList></td>
                <td width="20dp"><asp:Label ID="Spouse_LB" runat="server" Text="Spouse Fullname: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"> <asp:TextBox ID="SpouseName_tb" runat="server" Width="200px" ></asp:TextBox></td>
                
            </tr>
            <tr height="10dp"></tr>
            <tr>
                
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="EContact_LB" runat="server" Text="Emergency Contact:  " Font-Size="Larger" Widht="350px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="EContact_tb" runat="server" width="200px"></asp:TextBox> </td>
                <td width="20dp">
                    <asp:Label ID="Relationship_LB" runat="server" Text="Relationship: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Relation_tb" runat="server" Width="200px"></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="EPhone_LB" runat="server" Text="Emergengy Phone: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="EPhone_tb" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr height="50dp"></tr>
            <tr height="10dp">
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td width="20dp">
                    <asp:Button ID="Next_btn" runat="server" Text="Next" Width="100px" Font-Bold="true" Font-Size="Larger"/></td>
            </tr>
        </table>
    </form>
</body>
</html>
