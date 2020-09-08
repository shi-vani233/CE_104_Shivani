<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="lab7_task4.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">
                        <h2>Update</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                       sid:
                    </td>
                    <td>
                        <asp:TextBox ID="sidtext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Name:
                    </td>
                    <td>
                        <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Sem:
                    </td>
                    <td>
                        <asp:TextBox ID="semtext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        CPI:
                    </td>
                    <td>
                        <asp:TextBox ID="cpitext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Contact No:
                    </td>
                    <td>
                        <asp:TextBox ID="notext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email ID:
                    </td>
                    <td>
                        <asp:TextBox ID="emailtext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                    </td>
                </tr>
                <br />
                <br />
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
