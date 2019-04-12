<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteContact.aspx.cs" Inherits="ContactInfo2.DeletContact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Enter the full name of the contact you wish to delete:</div>
        <asp:TextBox ID="NameToDelete" runat="server" Width="162px"></asp:TextBox>
        <p>
            <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" Width="100px" />
            &nbsp;
            <asp:Button ID="Back" runat="server" Text="Back to Home" Width="100px" OnClick="Back_Click" />
        </p>
    </form>
</body>
</html>
