<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="lab6_task2.Product" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto">
                <tr>
                    <td>
                        <h1>
                            Products
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database %>" SelectCommand="SELECT [pid], [pname], [description], [cost] FROM [Product]"></asp:SqlDataSource>
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                          <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </td>
                </tr>
                <br />
                <br />
                <br />
                <tr>
                    <td >
                          <asp:Label ID="Label1" runat="server" Text="Select Your choice of item:"></asp:Label>
                    </td>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server" Height="109px" Width="147px" SelectionMode="Multiple"  DataSourceID="SqlDataSource1" DataTextField="pname" DataValueField="pid"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Order" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                         <h3><asp:Label ID="Label2" runat="server" ForeColor="red"></asp:Label></h3>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
