<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="project5.Members.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% Response.Write("Hello " + Context.User.Identity.Name + ", "); %> 
            Welcome to Member Page<br />
            <br />
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="HOME" />
        </div>

    </form>
</body>
</html>
