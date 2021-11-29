<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Suply.aspx.cs" Inherits="ClickToCart.Suply" %>

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
            height: 51px;
        }
        .auto-style3 {
            text-align: center;
            height: 33px;
        }
        .auto-style5 {
            position: absolute;
            top: 73px;
            left: 345px;
            z-index: 1;
            width: 216px;
            right: 896px;
            height: 30px;
        }
        .auto-style6 {
            position: absolute;
            top: 112px;
            left: 346px;
            z-index: 1;
            width: 215px;
            height: 26px;
        }
        .auto-style7 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="Teal" CssClass="inner" style="z-index: 1; position: absolute; top: 38px; left: 346px; width: 213px; height: 25px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                        <asp:Label ID="Label1" runat="server" Text="SUPLIER" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Text="SUPPLIER_ID:" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="auto-style7">
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="SUPPLIER_NAME:" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="Teal" CssClass="auto-style5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="SUPPLIER_GROUP_NAME:" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" BackColor="Teal" CssClass="auto-style6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="SUBMITS" BackColor="#CC0000" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
