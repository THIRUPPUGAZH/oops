<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductSingleView.aspx.cs" Inherits="ClickToCart.ProductSingleView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="stylesheet3.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 298px;
            height: 1780px;
            position: absolute;
            top: 14px;
            left: -4px;
            z-index: 1;
            margin-right: 106px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="D1" runat="server" RepeatColumns="1" Height="518px" CssClass="auto-style1" OnSelectedIndexChanged="D1_SelectedIndexChanged">
                <ItemTemplate>
                <table>
                    <tr>
                       
                   <td> <asp:Image ID="Image2" runat="server"  ImageUrl='<%#Eval("IMAGE_PATH") %>' Height="300px" Width="500px"></asp:Image> </td>
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
                         
                          
                        </td>
                        
                    </tr>
                </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
