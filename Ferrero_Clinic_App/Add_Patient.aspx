<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Patient.aspx.cs" Inherits="Ferrero_Clinic_App.Add_Patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    h1{text-align: center;}
        .auto-style1 {
            width: 208px;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style3 {
            width: 91px;
        }
        .auto-style4 {
            width: 1528px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style7 {
            width: 212px;
        }
        .auto-style8 {
            width: 1504px;
        }
        .display-next
        {
         display:block;
         float:right;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-size:30px ">PATIENT INFORMATION</h1>
        </div>
        
             <table style="margin-left:auto;margin-right:auto;" >
            <tr height="20"></tr>
            <tr height="30dp">
                <td width="20dp">&nbsp; </td>
                <td width="20dp">&nbsp; </td>
                <td width="20dp">&nbsp; </td>
                <td width="20dp"> <asp:Label ID="ID_LB" runat="server" Text="ID Number: " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"> <asp:TextBox ID="ID_tb" runat="server" Width="200"></asp:TextBox> </td>
                
                <asp:RequiredFieldValidator ID="idValidate" 
                         runat="server" ControlToValidate ="ID_tb"
                         ErrorMessage="Please enter your ID number" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>
            </tr>
            <tr height="20"></tr>


            <tr height="30dp">
                <td width="20dp">&nbsp; </td>
                <td width="20dp"><asp:Label ID="Name_LB" runat="server" Text="Name: " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Name_tb" runat="server"></asp:TextBox></td>
                <asp:RequiredFieldValidator ID="nameValidate" 
                         runat="server" ControlToValidate ="Name_tb"
                         ErrorMessage="Please enter your name" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>

                <td width="20dp"><asp:Label ID="Surname_LB" runat="server" Text="Surname: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Surname_tb" runat="server" ></asp:TextBox></td>
                 <asp:RequiredFieldValidator ID="surnameValidate" 
                         runat="server" ControlToValidate ="Surname_tb"
                         ErrorMessage="Please enter your surname" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>

                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Maiden_LB" runat="server" Text="Maiden: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Maiden_tb" runat="server"></asp:TextBox></td>
                 <asp:RequiredFieldValidator ID="maidenValidate" 
                         runat="server" ControlToValidate ="Maiden_tb"
                         ErrorMessage="Enter your maiden name" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                
            </tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Address_LB" runat="server" Text="Street Address:  " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Address_tb" runat="server" width="280px"></asp:TextBox> </td>
                 <asp:RequiredFieldValidator ID="addressValidate" 
                         runat="server" ControlToValidate ="Address_tb"
                         ErrorMessage="Enter your address" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>

                <td width="20dp">
                    <asp:Label ID="City_LB" runat="server" Text="City: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="City_tb" runat="server"></asp:TextBox></td>
                 <asp:RequiredFieldValidator ID="cityValidate" 
                         runat="server" ControlToValidate ="City_tb"
                         ErrorMessage="Enter the city" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>

                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td width="20dp"><asp:Label ID="State_LB" runat="server" Text="State: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp">
                    <asp:TextBox ID="State_tb" runat="server" ></asp:TextBox></td>
                 <asp:RequiredFieldValidator ID="stateValidate" 
                         runat="server" ControlToValidate ="State_tb"
                         ErrorMessage="Please enter the sate" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>

                <td width="20dp">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Zip_LB" runat="server" Text="Zip: " Font-Size="Larger"></asp:Label> </td>
                <td width="20dp">
                    <asp:TextBox ID="Zip_tb" runat="server" Width="80px"></asp:TextBox></td>
                 <asp:RequiredFieldValidator ID="zipValidate" 
                         runat="server" ControlToValidate ="Zip_tb"
                         ErrorMessage="Enter the zip code" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>
            </tr>
            <tr>
                <td width="20dp">&nbsp;</td>
               
                <td width="20dp">
                    <asp:Label ID="Phone_LB" runat="server" Text="Phone: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="PhoneNum_tb" runat="server"></asp:TextBox></td>
                 <asp:RequiredFieldValidator ID="phoneValidate" 
                         runat="server" ControlToValidate ="PhoneNum_tb"
                         ErrorMessage="Enter your phone number" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                
            </tr>
        <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Email_LB" runat="server" Text="Email:  " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Email_tb" runat="server" width="250px"></asp:TextBox> </td>
             <asp:RequiredFieldValidator ID="emailValidate" 
                         runat="server" ControlToValidate ="Email_tb"
                         ErrorMessage="Please enter you email" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>

                <td width="20dp">
                    <asp:Label ID="Occupation_LB" runat="server" Text="Occupation: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Occupation_tb" runat="server"></asp:TextBox></td>
             <asp:RequiredFieldValidator ID="occupationValidate" 
                         runat="server" ControlToValidate ="Occupation_tb"
                         ErrorMessage="Enter your occupation" ForeColor="DarkRed" Display="Static" CssClass="display-next"></asp:RequiredFieldValidator>

                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td width="20dp"><asp:Label ID="Employer_LB" runat="server" Text="Employer: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp">
                    <asp:TextBox ID="employer_tb" runat="server" ></asp:TextBox></td>
                <td width="20dp">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
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
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1"> <asp:Label ID="Gender_LB0" runat="server" Text="Gender: " Font-Size="Larger" Width="150px"></asp:Label></td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="176px" Font-Size="Larger">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                
            </tr>
            <tr>
                
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="EContact_LB" runat="server" Text="Emergency Contact:  " Font-Size="Larger" Widht="350px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="EContact_tb" runat="server" width="200px"></asp:TextBox> </td>
                <td width="20dp">
                    <asp:Label ID="Relationship_LB" runat="server" Text="Relationship: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Relation_tb" runat="server" Width="200px"></asp:TextBox></td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td width="20dp"><asp:Label ID="EPhone_LB" runat="server" Text="Emergengy Phone: " Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="EPhone_tb" runat="server" Width="200px"></asp:TextBox></td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                
            </tr>
            <tr height="10dp">
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp">
                    &nbsp;</td>
                <td widht="20dp" class="auto-style1">&nbsp;</td>
                <td widht="20dp" class="auto-style2"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp"></td>
                <td widht="20dp" class="auto-style3"></td>
                <td width="20dp">
                    &nbsp;</td>
            </tr>
            
        </table>
        <table style="margin-left:auto;margin-right:auto;" >
            <tr>
                <td widht="400dp" class="auto-style8"></td>
                <td widht="400dp" class="auto-style7">
                    <asp:Button ID="Next_btn" runat="server" Text="Next" Width="244px" Font-Bold="true" Font-Size="Larger" CssClass="auto-style5" OnClick="Next_btn_Click" /></td>
                <td widht="400dp" class="auto-style4"></td>
            </tr>
        </table>
    </form>
</body>
</html>
