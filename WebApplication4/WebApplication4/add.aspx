<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebApplication4.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="ALL.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            <asp:Label ID="Label1" runat="server" BackColor="Yellow" CssClass="menudiv" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="Black" Text="ADD RECORD HERE"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
&nbsp;<asp:TextBox ID="TXTNAME" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="AGE"></asp:Label>
            <asp:TextBox ID="TXTAGE" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="DEPARTMENT"></asp:Label>
            <asp:TextBox ID="TXTDPT" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ADDBUTTON" runat="server" Text="ADD RECORD"  OnClick="ADDbutt"/>
          
        </div>
    </form>
</body>
</html>
