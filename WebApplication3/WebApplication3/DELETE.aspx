<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DELETE.aspx.cs" Inherits="WebApplication3.DELETE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter ID to Delete:
<asp:TextBox ID="txtDelID" runat="server"></asp:TextBox>
<br /><br />

<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
<br /><br />
</div>

    </form>
</body>
</html>
