<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication4.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="ALL.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" BackColor="Yellow" BorderColor="Black" Font-Bold="True" Font-Underline="True" ForeColor="Black" Text="EMPLOYEE DATA  MANAGMENT SYSTEM" CssClass="centerhad" Font-Size="XX-Large"></asp:Label>
        <div>
        </div>
        <div class="menudiv">
            <br />
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="False" ForeColor="Black" PostBackUrl="~/showall.aspx">SHOW ALL RECORD</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" Font-Strikeout="False" Font-Underline="False" ForeColor="Black" OnClick="LinkButton2_Click" PostBackUrl="~/add.aspx">ADD RECORD</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" Font-Underline="False" ForeColor="Black" PostBackUrl="~/update.aspx">UPDATE RECORD</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton4" runat="server" Font-Underline="False" ForeColor="Black" PostBackUrl="~/delete.aspx">DELETE RECORD</asp:LinkButton>
            <br />
        </div>
    </form>
</body>
</html>
