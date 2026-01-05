<%@ Page Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="AdminLogin.aspx.cs"
    Inherits="ElectricityMiniProject.AdminLogin" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <h2>Admin Login</h2>

    Username:
    <asp:TextBox ID="txtUsername" runat="server" />
    <br /><br />

    Password:
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Button ID="btnLogin"
        runat="server"
        Text="Login"
        OnClick="btnLogin_Click" />

    <br /><br />

    <asp:Label ID="lblMsg"
        runat="server"
        ForeColor="Red" />

</asp:Content>
