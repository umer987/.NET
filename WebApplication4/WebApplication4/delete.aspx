<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="WebApplication4.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="ALL.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                       <asp:Label ID="Label1" runat="server" BackColor="Yellow" CssClass="menudiv" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="Black" Text="DELETE RECORD HERE"></asp:Label>

                       <br />
                       <br />
                       <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
&nbsp;<asp:TextBox ID="TXTDLT" runat="server"></asp:TextBox>
                       <br />
                       <br />
                       <asp:Button ID="dltbutton" runat="server" Text="DELETE RECORD" OnClick="dltbutt" />

        </div>
    </form>
</body>
</html>
