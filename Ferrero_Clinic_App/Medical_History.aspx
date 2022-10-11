﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medical_History.aspx.cs" Inherits="Ferrero_Clinic_App.Medical_History" %>

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
            <tr height="30dp">

                <td width="20dp">&nbsp; </td>
                <td width="20dp"><asp:Label ID="LB_1" runat="server" Text="Reason for visit: " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Reason_tb" runat="server" Width="400px"></asp:TextBox></td>
                <td width="20dp"></td>
                <td width="20dp"></td>
            </tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_2" runat="server" Text="List any previous medical problems:  " Font-Size="Larger" Width="300px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="PreviousProbs_tb" runat="server" width="480px"></asp:TextBox> </td>
                
                <td width="30dp"> <asp:Label ID="LB_3" runat="server" Text="Approximate Date: " Width="100px" Font-Size="Larger" style="float:right"></asp:Label></td>
                <td width="20pdp">
                    <asp:Calendar ID="Date_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar>
                </td>
                
            </tr>
            <tr height="10dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_4" runat="server" Text="List all current medications:  " Font-Size="Larger" Width="300px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="CurrentMedication_tb" runat="server" width="400px"></asp:TextBox> </td>
                <td width="30dp"> <asp:Label ID="LB_5" runat="server" Text="Dosage: " Width="80px" Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Dosage_tb" runat="server"></asp:TextBox></td>
                <td width="20dp"> <asp:Label ID="LB_6" runat="server" Text="Duration: " Font-Size="Larger" style="float:right" Width="80px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="Duration_tb" runat="server" ></asp:TextBox></td>
            </tr>
            <tr height="20dp"></tr>
            <tr> 
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_7" runat="server" Text="Do you have any allergies? " Width="250px" Font-Size="Larger"></asp:Label></td>
                <td width="20dp"><asp:RadioButton ID="Yes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="No_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                <td width="30dp">
                    <asp:Label ID="LB_8" runat="server" Text="List the allergies: " Width="150px" Font-Size="Larger"></asp:Label></td>
                <td width="20dp">
                    <asp:TextBox ID="Allergies_tb" runat="server" Width="200px "></asp:TextBox> </td>
            </tr>
            <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_9" runat="server" Text="List any major surgeries:  " Font-Size="Larger" Width="250px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="MajorSurgeries_tb" runat="server" width="400px"></asp:TextBox> </td>
                
                <td width="30dp"> <asp:Label ID="LB_10" runat="server" Text="Approximate Date: " Width="100px" Font-Size="Larger" style="float:right"></asp:Label></td>
                <td width="20pdp">
                    <asp:Calendar ID="SurgeryDate_cal" runat="server"  DayHeaderStyle-Font-Size="Medium" Width="10px"></asp:Calendar>
                </td>
            </tr>
            <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"><asp:Label ID="LB_11" runat="server" Text="List any family history of major medical problems:  " Font-Size="Larger" Width="300px"></asp:Label></td>
                <td width="20dp"><asp:TextBox ID="FamHistory_tb" runat="server" width="480px"></asp:TextBox> </td>
                
            </tr>
            <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"> <asp:Label ID="LB_12" runat="server" Text="Do you drink alcohol?  " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:RadioButton ID="AlcoholYes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="AlcoholNo_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                <td> <asp:Label ID="LB_13" runat="server" Text="If so, how often? " Font-Size="Larger" ></asp:Label></td>
                <td><asp:TextBox ID="AlcoholYes_tb" runat="server" width="200px"></asp:TextBox></td>
                
            </tr>
             <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"> <asp:Label ID="LB_14" runat="server" Text="Do you smoke cigarettes?  " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:RadioButton ID="SmaokeYes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="SmokeNo_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                <td> <asp:Label ID="LB_15" runat="server" Text="If so, how often? " Font-Size="Larger" ></asp:Label></td>
                <td><asp:TextBox ID="SmokeYes_tb" runat="server" width="200px"></asp:TextBox></td>
                
            </tr>
             <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"> <asp:Label ID="Lb_16" runat="server" Text="Do you take prescription drugs for non medical reason?  " Font-Size="Larger" Width="300px" ></asp:Label></td>
                <td width="20dp" ><asp:RadioButton ID="DrugsYes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="DrugsNo_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                
            </tr>
             <tr height="20dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"> <asp:Label ID="Lb_17" runat="server" Text="Do you take illegal drugs?  " Font-Size="Larger" ></asp:Label></td>
                <td width="20dp"><asp:RadioButton ID="IllegalYes_rbn" runat="server" Text="Yes" Font-Size="Larger"/> &nbsp;&nbsp;
                    <asp:RadioButton ID="IllegalNo_rbn" runat="server" Text="No" Font-Size="Larger"/>
                </td>
                
            </tr>
             <tr height="30dp"></tr>
            <tr>
                <td width="20dp">&nbsp;</td>
                <td width="20dp"></td>
                <td width="20dp">
                    <asp:Button ID="Next_btn" runat="server" Text="Next" Font-Bold="true" Font-Size="Larger" width="150px" style="float:right"/></td>
                <td width="20dp"></td>
                <td width="20dp"></td>
                
            </tr>
            <tr height="10dp"></tr>
           
          
            
        
        </table>
    </form>
</body>

</html>