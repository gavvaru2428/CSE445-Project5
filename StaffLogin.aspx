﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="project5.StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff Login Page<br />
            <br />
            Username :
            <asp:TextBox ID="txtNameStaff" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :
            <asp:TextBox ID="txtPassStaff" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            Image Verification Code<br />
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Captcha.aspx" />
            <br />
            <br />
            <br />
            Please Enter Verification Code<br />
            <asp:TextBox ID="imgVerBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnStaffLogin" runat="server" OnClick="btnStaffLogin_Click" Text="LOGIN" />
            <br />
            <br />
            <asp:Label ID="lblErrorLogin" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
