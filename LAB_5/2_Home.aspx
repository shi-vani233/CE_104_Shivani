<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Home.aspx.cs" Inherits="lab5_task2._2_Home" %>

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
                    <h1><asp:Label ID="Label1" runat="server" ></asp:Label></h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        Category:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="true">
                            <asp:Listitem Value="Electronics">
                                Electronics
                            </asp:Listitem>
                             <asp:Listitem Value="Books">
                                Books
                            </asp:Listitem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
           <br />
                <br />
                <tr>
                      <td>
                        <asp:Label ID="Label3" runat="server" Text="available items of selected category"></asp:Label>
                    </td>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server" Height="114px" Width="173px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="true" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                </tr>
                <br />
                <br />
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="selected items:"></asp:Label>
                    </td>
                    <td>
                        <asp:ListBox ID="ListBox2" runat="server" Height="72px" Width="135px" AppendDataBoundItems="True" AutoPostBack="True"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="order" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
