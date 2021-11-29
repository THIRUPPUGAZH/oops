<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ClickToCart.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="stylesheet1.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            height: 88px;
        }
        .auto-style3 {
            height: 29px;
        }
        .auto-style4 {
            position: absolute;
            top: 83px;
            left: 700px;
            z-index: 1;
            width: 149px;
            height: 40px;
        }
        .auto-style5 {
            position: absolute;
            top: 31px;
            left: 207px;
            z-index: 1;
            width: 246px;
            height: 32px;
            bottom: 707px;
        }
        .auto-style6 {
            position: absolute;
            top: 82px;
            left: 206px;
            z-index: 1;
            width: 248px;
            height: 32px;
        }
        .auto-style7 {
            text-align: center;
            height: 38px;
        }
        .auto-style8 {
            position: absolute;
            top: 114px;
            left: 1043px;
            z-index: 1;
            height: 45px;
            width: 235px;
            margin-left: 0px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" CssClass="auto-style8" OnClick="Button2_Click" Text="Back to Home" />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="ADMINLOGIN" Font-Bold="True" Font-Names="Arial Black" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="USERNAME:" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtuser" runat="server" CssClass="auto-style5" BackColor="Teal" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="PASSWORD:" Font-Bold="True"></asp:Label>
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" OnClick="Button1_Click" Text="LOGIN" BackColor="#CC0000" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtpass" runat="server" CssClass="auto-style6" BackColor="Teal"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
