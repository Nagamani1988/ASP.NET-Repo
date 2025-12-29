<%@ Page Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="ViewBill.aspx.cs"
    Inherits="ElectricityMiniProject.ViewBill" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <h2>View Last N Electricity Bills</h2>

    <table>
        <tr>
            <td>Enter Number of Bills:</td>
            <td>
                <asp:TextBox ID="txtN" runat="server" />
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <asp:Button ID="btnView"
                            runat="server"
                            Text="View Bills"
                            OnClick="btnView_Click" />
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <asp:GridView ID="gvBills"
                              runat="server"
                              AutoGenerateColumns="true"
                              BorderWidth="1"
                              BorderColor="Black" />
            </td>
        </tr>
    </table>

</asp:Content>
