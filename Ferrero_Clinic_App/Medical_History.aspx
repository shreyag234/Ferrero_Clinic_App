<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medical_History.aspx.cs" Inherits="Ferrero_Clinic_App.Medical_History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <style> 
        h1{text-align:center}
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-size:30px ">PATIENT MEDICAL HISTORY</h1>
        </div>
         <table style="margin-left:auto;margin-right:auto;" >
             <tr height="10dp"></tr>
            
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_2" runat="server" Text="Previous medical problems:  " Font-Size="Larger" Width="300px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="PreviousProbs_tb" runat="server" width="480px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="validate1" 
                         runat="server" ControlToValidate ="PreviousProbs_tb"
                         ErrorMessage="Please fill out" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
                
                
            </tr>
            <tr height="10dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_4" runat="server" Text="Current medications:  " Font-Size="Larger" Width="300px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="CurrentMedication_tb" runat="server" width="400px"></asp:TextBox> </td>
                <td width="30dp"> <asp:Label ID="LB_5" runat="server" Text="Dosage: " Width="80px" Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Dosage_tb" runat="server"></asp:TextBox></td>
                <td width="20dp"> <asp:Label ID="LB_6" runat="server" Text="Duration: " Font-Size="Larger" style="float:right" Width="80px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Duration_tb" runat="server" ></asp:TextBox></td>
            </tr>
            <tr height="20dp"></tr>
            <tr> 
                <td width="20dp">&nbsp;</td>
                
                <td width="30dp">
                    <asp:Label ID="LB_8" runat="server" Text="List the allergies: " Width="150px" Font-Size="Larger"></asp:Label></td>
                <td width="20dp">
                    <asp:TextBox ID="Allergies_tb" runat="server" Width="400px "></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="validate2" 
                         runat="server" ControlToValidate ="Allergies_tb"
                         ErrorMessage="Please select one" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
            </tr>
            <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_9" runat="server" Text="Major surgeries:  " Font-Size="Larger" Width="250px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="MajorSurgeries_tb" runat="server" width="400px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="validateMS" 
                         runat="server" ControlToValidate ="MajorSurgeries_tb"
                         ErrorMessage="Please fill out" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
                
                <td width="30dp"> <asp:Label ID="LB_10" runat="server" Text="Approximate Date: " Width="100px" Font-Size="Larger" style="float:right"></asp:Label></td>
                <td width="20pdp">
                    <asp:Calendar ID="SurgeryDate_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar>
                </td>
            </tr>
            <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_11" runat="server" Text="Any family history of major medical problems:  " Font-Size="Larger" Width="300px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="FamHistory_tb" runat="server" width="480px"></asp:TextBox> </td>
                <asp:RequiredFieldValidator ID="famHistoryValidate" 
                         runat="server" ControlToValidate ="FamHistory_tb"
                         ErrorMessage="Please provide the family medical history" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
                
            </tr>
            <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"> <asp:Label ID="LB_12" runat="server" Text="Do you drink alcohol?  " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:RadioButton ID="AlcoholYes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="AlcoholNo_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                <asp:RequiredFieldValidator ID="alcoholValidate" 
                         runat="server" ControlToValidate ="AlcoholYes_rbn"
                         ErrorMessage="Please select one" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>

                <td> <asp:Label ID="LB_13" runat="server" Text="If so, how often? " Font-Size="Larger" ></asp:Label></td>
                <td><asp:TextBox ID="AlcoholYes_tb" runat="server" width="200px"></asp:TextBox></td>
                
            </tr>
             <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"> <asp:Label ID="LB_14" runat="server" Text="Do you smoke cigarettes?  " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:RadioButton ID="SmokeYes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="SmokeNo_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                <asp:RequiredFieldValidator ID="validate" 
                         runat="server" ControlToValidate ="SmokeYes_rbn"
                         ErrorMessage="Please select one" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>

                <td> <asp:Label ID="LB_15" runat="server" Text="If so, how often? " Font-Size="Larger" ></asp:Label></td>
                <td><asp:TextBox ID="SmokeYes_tb" runat="server" width="200px"></asp:TextBox></td>
                
            </tr>
             <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                
                
            </tr>
             <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"> <asp:Label ID="Lb_17" runat="server" Text="Do you take illegal drugs?  " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:RadioButton ID="IllegalYes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="IllegalNo_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                <asp:RequiredFieldValidator ID="validatecheck" 
                         runat="server" ControlToValidate ="IllegalYes_rbn"
                         ErrorMessage="Please select one" ForeColor="DarkRed" Display="Dynamic" CssClass="display-next"></asp:RequiredFieldValidator>
                
            </tr>
             <tr height="30dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"></td>
                <td width="20dp">
                    <asp:Button ID="Next_btn" runat="server" Text="Next" Font-Bold="true" Font-Size="Larger" Width="150px" Style="float: right" OnClick="Next_btn_Click" /></td>
                <td width="20dp"></td>
                <td width="20dp"></td>
                
            </tr>
            <tr height="10dp"></tr>
           
          
            
        
        </table>
    </form>
</body>
</html>
