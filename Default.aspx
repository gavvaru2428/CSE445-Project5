<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="project5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome To
            Ecommerce Web Application<br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="MEMBER LOGIN" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="MEMBER REGISTER" />
            <br />
            <br />
            <asp:Button ID="btnStaffLogin" runat="server" OnClick="btnStaffLogin_Click" Text="STAFF LOGIN" />
            <br />
            <br />
            <asp:Button ID="btnMember" runat="server" Text="MEMBER PAGE" OnClick="btnMember_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnStaffPage" runat="server" OnClick="btnStaffPage_Click" Text="STAFF PAGE" />
        </div>
    </form>
</body>
</html>
