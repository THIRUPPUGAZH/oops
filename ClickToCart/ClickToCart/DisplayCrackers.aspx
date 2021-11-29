<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayCrackers.aspx.cs" Inherits="ClickToCart.DisplayCrackers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="stylesheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>  <asp:DataList ID="D1" runat="server" RepeatColumns="5" >
                <ItemTemplate>
                <table>
                    <tr>
                       
                   <td> <asp:Image ID="Image2" runat="server"  ImageUrl='<%#Eval("IMAGE_PATH") %>' Height="250px" Width="290px"></asp:Image> </td>
                        </hr>
                    </tr>
                    <br />
                   <tr>
                        <td>
                            ProductID:
                            <%#Eval("PRODUCT_ID") %><br />
                         

                        </td>
                        
                    </tr>
                    <tr>

                        <td>
                            ProductName:
                            <%#Eval("PRODUCT_NAME" )%><br />

                        </td>   
                        <br />
                        <br />
                        <br />
                        <br />
                    </tr>
                    <tr>


                        <td>
                            QuanityAvailable:
                            <%#Eval("QUANTITY" )%><br />

                        </td>   
                        <br />
                        <br />
                        <br />
                        <br />
                    </tr>
                     <td>
                            PRODUCT_DESCRIPTION:
                            <%#Eval(" PRODUCT_DESCRIPTION" )%><br />

                        </td>   
                        <br />
                        <br />
                        <br />
                        <br />
                    </tr>
                    
                    <tr>
                        <td>
                            ProductPrice:
                            <%#Eval("UNIT_PRICE") %><br />
                            <asp:Button ID="Buttonorder" runat="server" Text="Order" />
                            <asp:Button ID="ButtonAddCart" runat="server" Text="AddCart" />

                        </td>
                        
                    </tr>
                </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
