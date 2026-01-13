<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ValidatorProject.Products" %>

<html>
<head>
    <title>Products</title>
</head>
<body>
    <form runat="server">

        Select Product:
        <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="true"
            OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
        </asp:DropDownList>
        <br /><br />

        <asp:Image ID="imgProduct" runat="server" Width="200" />
        <br /><br />

        <asp:Button ID="btnPrice" runat="server" Text="Get Price"
            OnClick="btnPrice_Click" />
        <br /><br />

        <asp:Label ID="lblPrice" runat="server" Font-Bold="true" />

    </form>
</body>
</html>

