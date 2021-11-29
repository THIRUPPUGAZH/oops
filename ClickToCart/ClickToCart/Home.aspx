<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ClickToCart.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Welcome To Click To Cart</title>
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400" rel="stylesheet" /> <!-- https://fonts.google.com/ -->
    <link href="css/bootstrap.min.css" rel="stylesheet" /> <!-- https://getbootstrap.com/ -->
    <link href="fontawesome/css/all.min.css" rel="stylesheet" /> <!-- https://fontawesome.com/ -->
    <link href="css/templatemo-diagoona.css" rel="stylesheet" />
<!--

TemplateMo 550 Diagoona

https://templatemo.com/tm-550-diagoona

-->
     <script type="text/javascript" src="https://code.jquery.com/jquery-3.5.1.min.js"></script>  
<script>  
    $(window).on('load', function () {
        $(".container").fadeToggle("slow");
    });
</script>  

    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 29px;
            left: 41px;
            z-index: 1;
            width: 1594px;
            height: 748px;
        }
        .auto-style2 {
            position: absolute;
            top: 51px;
            left: 408px;
            z-index: 1;
            width: 292px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
       
        <div>
            <div class="container">  
       <img src="img/crack.gif" alt="" class="auto-style1">  
   </div> 
        </div>
   <div class="tm-container">        
        <div>
            <div class="tm-row pt-4">
                <div class="tm-col-left">
                    <div class="tm-site-header media">
                        <i class="fas fa-umbrella-beach fa-3x mt-1 tm-logo"></i>
                        <div class="media-body">
                            <h1 class="tm-sitename text-uppercase">CLICK TO CART&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#FFFF66"></asp:Label>
                            </h1>
                            <p class="tm-slogon" style="font-style:italic;">Find it, Love it, Buy it</p>
                        </div>        
                    </div>
                </div>
                <div class="tm-col-right">
                    <nav class="navbar navbar-expand-lg" id="tm-main-nav">
                        <button class="navbar-toggler toggler-example mr-0 ml-auto" type="button" 
                            data-toggle="collapse" data-target="#navbar-nav" 
                            aria-controls="navbar-nav" aria-expanded="false" aria-label="Toggle navigation">
                            <span><i class="fas fa-bars"></i></span>
                        </button>
                        <div class="collapse navbar-collapse tm-nav" id="navbar-nav">
                            <ul class="navbar-nav text-uppercase">
                                <li class="nav-item active">
                                   
                                    <asp:LinkButton ID="LinkButton2" class="nav-link tm-nav-link" runat="server" OnClick="LinkButton2_Click" >Home</asp:LinkButton>
                                </li>
                                <li class="nav-item">
                                        <asp:LinkButton ID="LinkButton1"  class="nav-link tm-nav-link" runat="server" OnClick="product_Click">Products</asp:LinkButton>
                                </li>
                                <li class="nav-item">
                                    
                                    <asp:LinkButton ID="LinkButton3" class="nav-link tm-nav-link" runat="server" OnClick="LinkButton3_Click">Cart</asp:LinkButton>
                                </li>  
                                
                                <li class ="nav-item">
                                    <asp:LinkButton ID="LinkButton4" Class="nav-link tm-nav-link"   runat="server" OnClick="Loing_Click">Login</asp:LinkButton>
                                </li>
                                <li class ="nav-item">
                                    <asp:LinkButton ID="LinkButton5" Class="nav-link tm-nav-link"   runat="server" OnClick="LinkButton5_Click">Signup</asp:LinkButton>
                                </li>
                                <li class ="nav-item">
                                    <asp:LinkButton ID="LinkButton6" Class="nav-link tm-nav-link"   runat="server" OnClick="LinkButton6_Click">Admin</asp:LinkButton>
                                </li>
                                <li class ="nav-item">
                                    <asp:LinkButton ID="btnLogout" Class="nav-link tm-nav-link"   runat="server" OnClick="Logout_Click">LOGOUT</asp:LinkButton>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link tm-nav-link" href="CONTACT.aspx">Contact</a>
                                </li>
                            </ul>                            
                        </div>                        
                    </nav>
                </div>
            </div>
            
            <div class="tm-row">
                <div class="tm-col-left"></div>
                <main class="tm-col-right">
                    <section class="tm-content">
                        <h2 class="mb-5 tm-content-title">Welcome!! To Click To Cart</h2>
                        <p class="mb-5">Whoever said cash can’t purchase joy basically didn’t know where to go shopping.</p>
                        
                        <p class="mb-5">People are continually going to go shopping. A considerable measure of our exertion is simply: ‘How would we make the retail encounter an incredible one?’</p>                        
                        
                    </section>
                </main>
            </div>
        </div>        

        <div class="tm-row">
            <div class="tm-col-left text-center">            
                <ul class="tm-bg-controls-wrapper">
                    <li class="tm-bg-control active" data-id="0"></li>
                    <li class="tm-bg-control" data-id="1"></li>
                    <li class="tm-bg-control" data-id="2"></li>
                </ul>            
            </div>        
            <div class="tm-col-right tm-col-footer">
                <footer class="tm-site-footer text-right">
                    <p class="mb-0">CLICK TO CART. 
                    
                    | <a rel="nofollow" target="_parent" href="https://templatemo.com" class="tm-text-link">Feel-good shopping.</a></p>
                </footer>
            </div>  
        </div>

        <!-- Diagonal background design -->
        <div class="tm-bg">
            <div class="tm-bg-left"></div>
            <div class="tm-bg-right"></div>
        </div>
    </div>
         </form>

    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.backstretch.min.js"></script>
    <script src="js/templatemo-script.js"></script>
</body>
</html>
