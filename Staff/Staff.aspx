﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="project5.Staff.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% Response.Write("Hello " + Context.User.Identity.Name + ", "); %> <br />
            Welcome to the Staff Page. This page is protected.<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="HOME" />
        </div>
    </form>
</body>
</html>