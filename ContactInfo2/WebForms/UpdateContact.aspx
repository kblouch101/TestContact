<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateContact.aspx.cs" Inherits="ContactInfo2.UpdateContact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Enter the full name of the contact you wish to update:"></asp:Label> <!--below is the full name of the person we want to edit-->
        </div>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Name:"></asp:Label>
        &nbsp;<asp:TextBox ID="Name" runat="server" Width="182px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Enter any new information for this contact."></asp:Label> <!--here we enter any new info - can leave blanks to not change things-->
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Name:"></asp:Label>
&nbsp;<asp:TextBox ID="NewName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Phone Number:"></asp:Label>
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
        <br />
    </form>
</body>
</html>
