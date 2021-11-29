<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AfterAdminLogin.aspx.cs" Inherits="ClickToCart.AfterAdminLogin" %>

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
            height: 30px;
        }
        .auto-style3 {
            position: absolute;
            top: 75px;
            left: 1118px;
            z-index: 1;
            width: 307px;
            height: 31px;
        }
        .auto-style4 {
            position: absolute;
            top: 75px;
            left: 557px;
            z-index: 1;
            width: 333px;
            height: 30px;
        }
        .auto-style5 {
            position: absolute;
            top: 75px;
            left: 44px;
            z-index: 1;
            width: 304px;
            height: 30px;
            right: 1117px;
            margin-left: 0px;
        }
        .auto-style6 {
            position: absolute;
            top: 311px;
            left: 323px;
            z-index: 1;
            width: 290px;
            height: 49px;
        }
        .auto-style7 {
            position: absolute;
            top: 314px;
            left: 917px;
            z-index: 1;
            width: 300px;
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CATEGORIES" BackColor="#CC0000" CssClass="auto-style5" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="PRODUCTLOAD" BackColor="#CC0000" CssClass="auto-style4" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="SUPLIER" BackColor="#CC0000" CssClass="auto-style3" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button5" runat="server" BackColor="Aqua" CssClass="auto-style6" OnClick="Button5_Click" Text="UPDATE USER" />
        </p>
        <asp:Button ID="Button6" runat="server" BackColor="Aqua" CssClass="auto-style7" OnClick="Button6_Click" Text="UPDATE PRODUCT" />
    </form>
</body>
</html>
