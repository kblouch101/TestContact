<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation.aspx.cs" Inherits="ContactInfo2.Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        &nbsp;Contact Information.<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="What would you like to do?"></asp:Label>
        <p>
            <asp:Button ID="btnGoToAdd" runat="server" Text="Add Contact" OnClick="btnGoToAdd_Click" Width="125px" />
            &nbsp;
            <asp:Button ID="btnGoToDelete" runat="server" style="margin-top: 3px" Text="Delete Contact" OnClick="btnGoToDelete_Click" Width="125px" />
        </p>
        <asp:Button ID="btnGoToUpdate" runat="server" Text="Update Contact" Width="125px" OnClick="btnGoToUpdate_Click" />
        &nbsp;
        <asp:Button ID="btnGoToView" runat="server" Text="View Contacts" Width="125px" OnClick="btnGoToView_Click" />
        <br />
        <br />
        <br />
        <br />
        Uses ASP.NET and ADO.NET to connect and work with a SQL database.<br />
        By: Kiersten Blouch<p>
            &nbsp;</p>
    </form>
</body>
</html>
