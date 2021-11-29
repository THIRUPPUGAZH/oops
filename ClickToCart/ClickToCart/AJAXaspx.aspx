<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAXaspx.aspx.cs" Inherits="ClickToCart.AJAXaspx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ajax:ToolkitScriptManager ID="ToolkitScriptManager2" runat="server"></ajax:ToolkitScriptManager>

            <ajax:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" ServiceMethod="GetCompletionList" TargetControlID="TextBox1"></ajax:AutoCompleteExtender>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
