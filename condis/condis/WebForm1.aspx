<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="condis.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
&nbsp;<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="CONN"  OnClick="btn_connected_Click"/>
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="DISCONN" OnClick="btn_disconnected_Click"/>
        </div>
    </form>
</body>
</html>
