<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lab4_task2.Home" %>

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
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Full Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="textname" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textname" Text="name is required" ErrorMessage="name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="textage" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator  ID="RangeValidatorAge" runat="server" ControlToValidate="textage" Display="Dynamic" ErrorMessage="Age must be in 18 and 50" Forecolor="Red" MaximumValue="50" MinimumValue="18" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="textpassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text=" Confirm Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="textconfirm" runat="server" TextMode="Password"></asp:TextBox></td>
                     <td><asp:CompareValidator ID="CompareValidatorConfirmPassword" runat="server" ControlToCompare="textpassword" ControlToValidate="textconfirm" Display="Dynamic" ErrorMessage="Password and Confirm Password must be same" Forecolor="red" ></asp:CompareValidator> </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label></td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="Male">Male</asp:ListItem>
                              <asp:ListItem Value="Female">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Mobile No."></asp:Label></td>
                    <td>
                        <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegulatorExpressionValidatorMobileNo" runat="server" ControlToValidate="mob"  ErrorMessage="Mobile no. must be of 10 digits" ForeColor="Red" ValidateExpression="[1-9][0-9]{9}"></asp:RegularExpressionValidator> 
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Hobbies"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem Value="Reading">Reading</asp:ListItem>
                              <asp:ListItem Value="Painting">Painting</asp:ListItem>
                              <asp:ListItem Value="Cycling">Cycling</asp:ListItem>
                              <asp:ListItem Value="Singing">Singing</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="State"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Value="-1">select state</asp:ListItem>
                             <asp:ListItem Value="Gujarat">Gujarat</asp:ListItem>
                              <asp:ListItem Value="Maharastra">Maharastra</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                             <asp:ListItem Value="-1">select city</asp:ListItem>
                             <asp:ListItem Value="Ahmedabad">Ahmedabad</asp:ListItem>
                              <asp:ListItem Value="Vadodara">Vadodara</asp:ListItem>
                            <asp:ListItem Value="Mumbai">Mumbai</asp:ListItem>
                            <asp:ListItem Value="Pune">Pune</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="PAN Number"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="pan" runat="server"></asp:TextBox>
                    </td>
                    <td>
                         <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="pan" ErrorMessage="Please provide valid PAN number" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                       </td>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" Text="submit" OnClick="btnsubmit_Click"/> </td>
                </tr>
                <tr>
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </tr>
                <br />
                <tr>
                    <asp:Label ID="Label12" runat="server" ></asp:Label>
                </tr><br />
                  <tr>
                    <asp:Label ID="Label13" runat="server" ></asp:Label>
                </tr><br />
                 <tr>
                    <asp:Label ID="Label14" runat="server" ></asp:Label>
                </tr><br />
                 <tr>
                    <asp:Label ID="Label15" runat="server" ></asp:Label>
                </tr><br />
                 <tr>
                    <asp:Label ID="Label16" runat="server" ></asp:Label>
                </tr><br />
                 <tr>
                    <asp:Label ID="Label17" runat="server" ></asp:Label>
                </tr><br />
                 <tr>
                    <asp:Label ID="Label18" runat="server" ></asp:Label>
                </tr><br />
                 <tr>
                    <asp:Label ID="Label19" runat="server" ></asp:Label>
                </tr><br />
                 <tr>
                    <asp:Label ID="Label20" runat="server" ></asp:Label>
                </tr>
                <br />
            </table>
        </div>
    </form>
</body>
</html>
