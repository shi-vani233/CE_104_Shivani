<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Order.aspx.cs" Inherits="lab5_task2._2_Order" %>

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
                    <h1><asp:Label ID="Label2" runat="server" ></asp:Label></h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <h1>your order</h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                       <h3><asp:Label ID="Label1" runat="server" ></asp:Label></h3>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
