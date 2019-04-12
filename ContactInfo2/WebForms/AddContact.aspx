<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddContact.aspx.cs" Inherits="ContactInfo2.AddContact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Enter all information for the new contact below.<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
        &nbsp;<asp:TextBox ID="Name" runat="server" Width="182px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Phone Number:"></asp:Label>
        &nbsp;<asp:TextBox ID="Number" runat="server" Width="124px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
&nbsp;<asp:TextBox ID="Email" runat="server" Width="183px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Street Address:"></asp:Label>
&nbsp;<asp:TextBox ID="StAddress" runat="server" Width="125px"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="City:"></asp:Label>
&nbsp;<asp:TextBox ID="City" runat="server" Width="193px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="State:"></asp:Label>
        &nbsp;<asp:TextBox ID="State" runat="server" Width="189px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" Width="100px" />
    &nbsp;
        <asp:Button ID="Back" runat="server" Text="Back to Home" Width="100px" OnClick="Back_Click" />
    </form>
</body>
</html>
