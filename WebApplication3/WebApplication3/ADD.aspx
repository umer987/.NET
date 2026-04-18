<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADD.aspx.cs" Inherits="WebApplication3.ADD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label2" runat="server" Text="ADD DATA"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="NAME"></asp:Label>
            <asp:TextBox ID="name1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="AGE"></asp:Label>
            <asp:TextBox ID="age1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="CITY"></asp:Label>
            <asp:TextBox ID="city1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="add_click" />
            <br />
            
        </div>
    </form>
</body>
</html>
