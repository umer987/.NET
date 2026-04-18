<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="agprac.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
            <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="delete"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="id"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
&nbsp;<asp:Button ID="Button1" runat="server" Height="34px" Text="delete" Width="75px" OnClick="dlt_butt"/>
        </div>
    </form>
</body>
</html>
