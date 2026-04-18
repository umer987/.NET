<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="CRUD APPLICATION UMER" CssClass="center-label" ></asp:Label>
    <p>
        &nbsp;</p>
        <asp:Label ID="Label2" runat="server" Text="ADD"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" BackColor="Aqua" BorderColor="Black" BorderWidth="1px" CssClass="pdd" PostBackUrl="~/ADD.aspx">ADD</asp:LinkButton>
        <br />
        <asp:Label ID="Label3" runat="server" Text="UPDATE"></asp:Label>
        <asp:LinkButton ID="LinkButton2" runat="server" BackColor="Aqua" BorderColor="Black" BorderWidth="1px" CssClass="pdd" PostBackUrl="~/UPDATE.aspx">UPDATE</asp:LinkButton>
        <br />
        DELETE
        <asp:LinkButton ID="LinkButton3" runat="server" BackColor="Aqua" BorderWidth="1px" CssClass="pdd" PostBackUrl="~/DELETE.aspx">DELETE</asp:LinkButton>
        <br />
        <asp:Label ID="Label4" runat="server" Text="SHOW ALL"></asp:Label>
        <asp:LinkButton ID="LinkButton4" runat="server" BackColor="Aqua" BorderWidth="1px" CssClass="pdd" PostBackUrl="~/showall.aspx">SHOW ALL</asp:LinkButton>
    </form>
</body>
</html>
