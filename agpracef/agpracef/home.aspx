<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="agpracef.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="add records"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="student name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="father name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="department"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="add" OnClick="add"/>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="student_id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="student_id" HeaderText="student_id" InsertVisible="False" ReadOnly="True" SortExpression="student_id" />
                    <asp:BoundField DataField="student_name" HeaderText="student_name" SortExpression="student_name" />
                    <asp:BoundField DataField="father_name" HeaderText="father_name" SortExpression="father_name" />
                    <asp:BoundField DataField="department" HeaderText="department" SortExpression="department" />
              <asp:CommandField ShowEditButton="true" />
                    <asp:CommandField ShowDeleteButton="true" />
                    </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentsConnectionString %>" SelectCommand="SELECT * FROM [students_records]" UpdateCommand="UPDATE students_records SET student_name=@student_name , father_name =@father_name , department=@department WHERE student_id=@student_id" DeleteCommand="DELETE FROM students_records WHERE student_id=@student_id"></asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
