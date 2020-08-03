<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="Lab4_task2.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <td>
                <tr>
                    CLICK BUTTON TO SHOW OR DISAPPEARS IMAGE  
                   
                </tr>
                <tr>
                    <asp:Button ID="Button1" runat="server" Text="show" OnClick="Button1_Click" />
                </tr>
                <tr>
                    <asp:Image ID="image1" runat="server"   ImageUrl="~/image1.jpg" Height="318px" Width="520px" style="margin-left: 600px" />
                </tr>
            </td>
        </div>
    </form>
</body>
</html>
