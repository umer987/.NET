<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="efprac.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="HOUSE MANAGMENT SYSTEM"></asp:Label>
&nbsp;<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="OWNER NAME"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="HOUSE ADDRESS"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="25px" Text="ADD RECORD" Width="117px" OnClick="Add_butt" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" DataKeyNames="id">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="owner_name" HeaderText="owner_name" SortExpression="owner_name" />
                    <asp:BoundField DataField="house_address" HeaderText="house_address" SortExpression="house_address" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="owner_name" HeaderText="owner_name" SortExpression="owner_name" />
                    <asp:BoundField DataField="house_address" HeaderText="house_address" SortExpression="house_address" />
                <asp:CommandField ShowEditButton="True" />
                     <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:house_efConnectionString2 %>" ProviderName="<%$ ConnectionStrings:house_efConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [house_records]" UpdateCommand="UPDATE house_records set owner_name=@owner_name, house_address=@house_address where id = @id" DeleteCommand="DELETE from house_records where id =@id"></asp:SqlDataSource>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
