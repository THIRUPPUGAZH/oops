<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDisplay.aspx.cs" Inherits="ClickToCart.ProductDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   
    <title>OUR PRODUCTS</title>
    <link href="stylesheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 1477px;
            height: 130px;
            position: absolute;
            top: 15px;
            left: 10px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 43px;
            left: 72px;
            z-index: 1;
            width: 129px;
            height: 43px;
            right: 1276px;
        }
        .auto-style3 {
            position: absolute;
            top: 44px;
            left: 295px;
            z-index: 1;
            width: 167px;
            height: 40px;
        }
        .auto-style4 {
            position: absolute;
            top: 41px;
            left: 579px;
            z-index: 1;
            width: 152px;
            height: 39px;
            right: 746px;
        }
        .auto-style5 {
            position: absolute;
            top: 42px;
            left: 842px;
            z-index: 1;
            width: 169px;
            height: 37px;
        }
        .auto-style6 {
            position: absolute;
            top: 45px;
            left: 1088px;
            z-index: 1;
            width: 169px;
            height: 35px;
            bottom: 50px;
        }
        .auto-style7 {
            position: absolute;
            top: 45px;
            left: 1294px;
            z-index: 1;
            width: 166px;
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" style="z-index: 1">
                 <asp:Button ID="Button1" runat="server" Text="CRACKERS" CssClass="auto-style2" OnClick="Button1_Click" />
                 <br />
                 <asp:Button ID="Button6" runat="server" CssClass="auto-style7" OnClick="Button6_Click" Text="Home" />
                 <br />
                 <asp:Button ID="Button2" runat="server" CssClass="auto-style3" OnClick="Button2_Click" Text="COOLERS" />
                 <asp:Button ID="Button4" runat="server" CssClass="auto-style5" OnClick="Button4_Click" Text="FACE MASK" />
                 <asp:Button ID="Button5" runat="server" CssClass="auto-style6" OnClick="Button5_Click" Text="CART" />
                 <asp:Button ID="Button3" runat="server" CssClass="auto-style4" OnClick="Button3_Click" Text="STATIONARY" />
             </asp:Panel>
             <br />
             <br />
             <br />
             <br />
             <br />
             <br />
             <br />
             <br />
             <br />
             <br />
             <br />
           
        </div>
            <asp:DataList ID="D1" runat="server" RepeatColumns="6" Height="518px" OnSelectedIndexChanged="D1_SelectedIndexChanged"  OnItemCommand="ProductSingleView">
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
                          
                            <asp:LinkButton ID="LinkButton2" CommandName="AddToCart" CommandArgument='<%#Eval("PRODUCT_ID") %>'  runat="server" OnClick="btn_click">Add To Cart</asp:LinkButton>
                            
                            <asp:LinkButton ID="LinkButton1" CommandName="ViewProduct" CommandArgument='<%#Eval("PRODUCT_ID") %>'  runat="server">View</asp:LinkButton>

                        </td>
                        
                    </tr>
                </table>
                </ItemTemplate>
            </asp:DataList>

           
    </form>
</body>
</html>
