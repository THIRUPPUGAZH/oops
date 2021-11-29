<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ClickToCart.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="stylesheet1.css" rel="stylesheet" />
<title>Student Registration Form</title>

    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 403px;
            left: 744px;
            z-index: 1;
            height: 51px;
            width: 240px;
        }
    </style>

</head>

<body>
    <form id="form1" runat="server">
      
<h3> USER REGISTRATION FORM</h3>



 
<table align="center" cellpadding = "10">
    <!----- User Name ---------------------------------------------------------->
<tr>
<td>USER NAME:</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
&nbsp;(max 30 characters a-z and A-Z)
</td>
</tr>
 
<!----- First Name ---------------------------------------------------------->
<tr>
<td>FIRST NAME:</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;(max 30 characters a-z and A-Z)
</td>
</tr>
 
<!----- Last Name ---------------------------------------------------------->
<tr>
<td>LAST NAME:</td>
<td>&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
(max 30 characters a-z and A-Z)
</td>
</tr>
 
<!----- Date Of Birth -------------------------------------------------------->
<tr>
<td>DATE OF BIRTH:</td>
 
<td>
&nbsp;
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;</td>
</tr>
 
<!----- Email Id ---------------------------------------------------------->
<tr>
<td>EMAIL ID:</td>
<td>
    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
    </td>
</tr>
 
<!----- Mobile Number ---------------------------------------------------------->
<tr>
<td>MOBILE NUMBER:</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;(10 digit number)
</td>
</tr>
 
<!----- Gender ----------------------------------------------------------->
<tr>
<td>GENDER:</td>
<td>
Male <input type="radio" name="Gender" value="Male" />
Female&nbsp; <input type="radio" name="Gender" value="Female" checked="true" /></td>
</tr>
 
<!----- Address ---------------------------------------------------------->
<tr>
<td>ADDRESS :<br /><br /><br /></td>
<td>
    <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style1" TextMode="MultiLine"></asp:TextBox>
    </td>
</tr>
 
<!----- City ---------------------------------------------------------->
<tr>
<td>CITY:</td>
<td>&nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
(max 30 characters a-z and A-Z)
</td>
</tr>
 
<!----- ZIP---------------------------------------------------------->
<tr>
<td>ZIP:</td>
<td>&nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
(6 digit number)
</td>
</tr>
 
<!----- State -------------------------------------------------------
<tr>
<td>STATE:</td>
<td>&nbsp;<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
(max 30 characters a-z and A-Z)
</td>
</tr>--->
 
<!----- Country ---------------------------------------------------------->
<tr>
<td>COUNTRY:</td>
<td>
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    </td>
</tr>



<tr>
<td>PASSWORD:</td>
<td>
    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
    </td>
</tr>





<!----- Submit and Reset ------------------------------------------------->

<td colspan="2" align="center">
&nbsp;
    <asp:Button ID="BTNSUBMIT" runat="server" OnClick="BTNSUBMIT_Click" Text="SUBMIT" />
</td>
 
</table>
 
</form>
    
</body>
</html>
