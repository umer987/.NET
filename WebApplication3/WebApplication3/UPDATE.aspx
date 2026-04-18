<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UPDATE.aspx.cs" Inherits="WebApplication3.UPDATE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            <asp:Label ID="Label1" runat="server" Text="UPDATE BY ID"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="dltid" runat="server"></asp:TextBox>
            <br />
          <asp:Label ID="Label3" runat="server" Text="NAME"></asp:Label>
<asp:TextBox ID="name2" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="AGE"></asp:Label>
<asp:TextBox ID="age2" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label5" runat="server" Text="CITY"></asp:Label>
<asp:TextBox ID="city2" runat="server"></asp:TextBox>
            <br />
<br />
<asp:Button ID="Button2" runat="server" Text="UPDATE" OnClick="update_click" />
<br />
        </div>
    </form>
</body>
</html>
