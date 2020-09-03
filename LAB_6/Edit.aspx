<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="lab6_task1.Edit" %>

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
                    <td colspan="2">
                        <h1>Enter ID of student to fetch his details</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="id" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Fetch Details" OnClick="Button1_Click" />
                    </td>
                </tr>
                <br />
                <br />
                <br />
                 <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Semester"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="sem" runat="server"></asp:TextBox>
                    </td>

                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Mobile No."></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                    </td>
                </tr>
         
                <tr>
                    <td colspan="2">
                     <h3><asp:Label ID="Label6" runat="server"></asp:Label></h3>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
