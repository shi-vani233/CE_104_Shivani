<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Cookie.aspx.cs" Inherits="lab5_task1._1_Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto" >
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="city"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="create cookie" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="show cookie" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="delete cookie" OnClick="Button3_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                  <h3> <asp:Label ID="Label4" runat="server"></asp:Label> </h3>
                        </td>
                </tr>
            
                </table>
        </div>
    </form>
</body>
</html>
