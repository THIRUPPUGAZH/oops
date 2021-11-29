<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CATEGORIES.aspx.cs" Inherits="ClickToCart.CATEGORIES" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="stylesheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            height: 13px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            position: absolute;
            top: 68px;
            left: 288px;
            z-index: 1;
            height: 26px;
            width: 303px;
        }
        .auto-style5 {
            position: absolute;
            top: 36px;
            left: 287px;
            z-index: 1;
            height: 23px;
            width: 304px;
        }
        .auto-style6 {
            position: absolute;
            top: 103px;
            left: 287px;
            z-index: 1;
            height: 26px;
            width: 308px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="CATEGORIES" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="CATEGORY_ID:" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="Teal" CssClass="auto-style5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="CATEGORY_NAME:" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="Teal" CssClass="auto-style4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="CATEGORY_DESCRIPTION:" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" BackColor="Teal" CssClass="auto-style6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="SUBMIT" BackColor="#CC0000" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
