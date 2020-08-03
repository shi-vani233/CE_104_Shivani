<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab4_task2.Login" %>

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
                        <asp:Label ID="Label1" runat="server" Text="username"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="textusername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="textpassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                       </td>
                    <td>
                        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"/> </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="error" runat="server" Text="Incorrect credentials" ForeColor="red"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
