<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ValidatorProject.Validator" %>

<!DOCTYPE html>
<html>
<head>
    <title>Validator</title>
</head>
<body>
    <form runat="server">

        Name:
        <asp:TextBox ID="txtName" runat="server" />
        <br />

        Family Name:
        <asp:TextBox ID="txtFamily" runat="server" />
        <asp:CustomValidator 
            ID="cvNameFamily" 
            runat="server"
            ControlToValidate="txtFamily"
            ErrorMessage="Name and Family Name should be different"
            OnServerValidate="ValidateNameFamily"
            ForeColor="Red" />
        <br />

        Address:
        <asp:TextBox ID="txtAddress" runat="server" />
        <asp:RequiredFieldValidator runat="server"
            ControlToValidate="txtAddress"
            ErrorMessage="Address required"
            ForeColor="Red" />
        <asp:RegularExpressionValidator runat="server"
            ControlToValidate="txtAddress"
            ValidationExpression=".{2,}"
            ErrorMessage="Minimum 2 letters"
            ForeColor="Red" />
        <br />

        City:
        <asp:TextBox ID="txtCity" runat="server" />
        <asp:RegularExpressionValidator runat="server"
            ControlToValidate="txtCity"
            ValidationExpression=".{2,}"
            ErrorMessage="City must have at least 2 letters"
            ForeColor="Red" />
        <br />

        Zip Code:
        <asp:TextBox ID="txtZip" runat="server" />
        <asp:RegularExpressionValidator runat="server"
            ControlToValidate="txtZip"
            ValidationExpression="^\d{5}$"
            ErrorMessage="Zip must be 5 digits"
            ForeColor="Red" />
        <br />

        Phone:
        <asp:TextBox ID="txtPhone" runat="server" />
        <asp:RegularExpressionValidator runat="server"
            ControlToValidate="txtPhone"
            ValidationExpression="^\d{2,3}-\d{7}$"
            ErrorMessage="Phone format XX-XXXXXXX or XXX-XXXXXXX"
            ForeColor="Red" />
        <br />

        Email:
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RegularExpressionValidator runat="server"
            ControlToValidate="txtEmail"
            ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
            ErrorMessage="Invalid Email"
            ForeColor="Red" />
        <br /><br />

        <asp:Button ID="btnCheck" runat="server" Text="Check" style="height: 35px" Width="83px" />
    </form>
</body>
</html>
