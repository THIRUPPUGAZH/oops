<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClickToCart.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="stylesheet2.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 15px;
        }
    </style>
</head>
    <body>
    <form id="form1" runat="server">
        <h1>Click To Cart Log In</h1>
        <div class="inset">
            <p class="auto-style1">
                USER NAME :
            </p>
            <p>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;
            </p>
            <p>
                PASSWORD :
            </p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                &nbsp;
            </p>
            <p>
                

                <label for="remember">Remember me for 14 days</label></p>
            <p>
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
&nbsp;</p>
        </div>
        <p class="p-container">
            <span>Forgot password ?</span>&nbsp;
        </p>
    </form>



</body>
</html>
