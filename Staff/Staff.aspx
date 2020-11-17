<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="project5.Staff.Staff" %>

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
            <br />
            <br />
            As a Staff member you are entitled to use the below two services.<br />
            <br />
            Service 1<br />
            <br />
            Product pickup distance calculator Service&nbsp; - calculate the minimum distance that the buyer and seller has to travel to buy/sell product<br />
            <br />
            Method name - deliveryDistanceCalculator- String zipcode 1 and String zipcode 2<br />
            <br />
            URL - <a href="http://webstrar74.fulton.asu.edu/page10/Service1.svc/deliverydistancecalculator/85280/85281">http://webstrar74.fulton.asu.edu/page10/Service1.svc/deliverydistancecalculator/85280/85281</a>
            <br />
            <br />
            Please enter the zipcode of the buyer in the below textbox(Example : 85280)<br />
            <asp:TextBox ID="zipcode1TB" runat="server" Width="722px"></asp:TextBox>
            <br />
            <br />
            Please enter the zipcode of the seller in the below textbox(Example : 85281)<br />
            <asp:TextBox ID="zipcode2TB" runat="server" Width="716px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="deliveryBtn" runat="server" OnClick="deliveryBtn_Click" Text="Submit" Width="91px" />
            <br />
            <br />
            Please find the status of the service request in the below textbox<br />
            <asp:TextBox ID="deliveryResultTB" runat="server" Width="1008px"></asp:TextBox>
            <br />
            <br />
            <br />
            Service 2<br />
            <br />
            Find the Nearest Store - Finds the nearest store given the ZipCode
            <br />
            <br />
            Method Name - findNearestStore , Parameters - zipcode{String} and StoreName{String}<br />
            <br />
            URL - <a href="http://webstrar74.fulton.asu.edu/page10/Service1.svc/findNearestStore/85281/Walmart">http://webstrar74.fulton.asu.edu/page10/Service1.svc/findNearestStore/85281/Walmart</a>
            <br />
            <br />
            Please Enter the 5 letter zipcode/postal code in the below tex tbox. (Example: 85281)<br />
            <asp:TextBox ID="neareststorezipcodeTB" runat="server" Width="783px"></asp:TextBox>
            <br />
            <br />
            Please Enter the Store name in the below text box.(Example: Walmart)<br />
            <asp:TextBox ID="neareststoreTB" runat="server" Width="776px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="neareststoreBtn" runat="server" OnClick="neareststoreBtn_Click" Text="Submit" />
            <br />
            <br />
            Please find the result of the above Nearest Store operation below.<br />
            <asp:TextBox ID="nearestStoreResultTB" runat="server" Width="1011px"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
