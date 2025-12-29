<%@ Page Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="AddBill.aspx.cs"
    Inherits="ElectricityMiniProject.AddBill" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <h2>Add Electricity Bill</h2>

    Number of bills to be added:
    <asp:TextBox ID="txtTotalBills" runat="server" /><br /><br />

    Consumer Number:
    <asp:TextBox ID="txtConsumerNo" runat="server" /><br />

    Consumer Name:
    <asp:TextBox ID="txtName" runat="server" /><br />

    Units Consumed:
    <asp:TextBox ID="txtUnits" runat="server" /><br /><br />

    <asp:Button ID="btnAdd" runat="server"
        Text="Add Bill"
        OnClick="btnAdd_Click" />

    <br /><br />
    <asp:Label ID="lblMsg" runat="server" />

</asp:Content>
