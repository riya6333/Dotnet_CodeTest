<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment1_ASP.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validations</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:blue;font-size:20px;text-align:center;">Validator Form </h1>
            <br />
            Name: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            &nbsp<asp:RequiredFieldValidator ID="rfvName" runat="server"
                ControlToValidate="txtName" ErrorMessage="Name Cannot Be Blank" ForeColor="Red" ValidationGroup="validatorGroup">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Family Name: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvFamilyName" runat="server"
                ControlToValidate="txtFamilyName" ErrorMessage="Family Name Cannot Be Blank" ForeColor="Red" ValidationGroup="validatorGroup">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Address: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvAddress" runat="server"
                ControlToValidate="txtAddress" ErrorMessage="Address Cannot Be Blank" ForeColor="Red" ValidationGroup="validatorGroup">*</asp:RequiredFieldValidator>
            <br />
            <br />
            City: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvCity" runat="server"
                ControlToValidate="txtCity" ErrorMessage="City Cannot Be Blank" ForeColor="Red" ValidationGroup="validatorGroup">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Zip Code: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvZipCode" runat="server"
                ControlToValidate="txtZipCode" ErrorMessage="Zip Code Cannot Be Blank" ForeColor="Red" ValidationGroup="validatorGroup">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="revZipCode" runat="server"
                ControlToValidate="txtZipCode" ErrorMessage="Zip Code should be 5 digits" ForeColor="Red"
                ValidationExpression="^\d{5}$" ValidationGroup="validatorGroup">*</asp:RegularExpressionValidator>
            <br />
            <br />
            Phone: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvPhone" runat="server"
                ControlToValidate="txtPhone" ErrorMessage="Phone Cannot Be Blank" ForeColor="Red" ValidationGroup="validatorGroup">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="revPhone" runat="server"
                ControlToValidate="txtPhone" ErrorMessage="Phone should be in format XX-XXXXXXX or XXX-XXXXXXX" ForeColor="Red"
                ValidationExpression="^\d{2,3}-\d{7}$" ValidationGroup="validatorGroup">*</asp:RegularExpressionValidator>
            <br />
            <br />
            Email: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                ControlToValidate="txtEmail" ErrorMessage="Email Cannot Be Blank" ForeColor="Red" ValidationGroup="validatorGroup">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="revEmail" runat="server"
                ControlToValidate="txtEmail" ErrorMessage="Invalid Email format" ForeColor="Red"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="validatorGroup">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" ValidationGroup="validatorGroup" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="validatorGroup" />
        </div>
    </form>
</body>
</html>
