<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="project5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login<br />
            <br />
            Username:
            <asp:TextBox ID="txtMemName" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="txtMemPass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnMemLogin" runat="server" Text="LOGIN" OnClick="btnMemLogin_Click" />
            <br />
            <br />
            New User? Please
            <asp:HyperLink ID="linkRegister" runat="server" NavigateUrl="~/MemberRegister.aspx">Register</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="HOME" />
            <br />
            <br />
            <asp:Label ID="lblErrorLogin" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
