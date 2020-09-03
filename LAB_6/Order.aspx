<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="lab6_task2.Order" %>

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
                                your Order
                            </h1>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h3><asp:Label ID="Label2" runat="server"></asp:Label></h3>
                        </td>
                    </tr>
                </table>
        </div>
    </form>
</body>
</html>
