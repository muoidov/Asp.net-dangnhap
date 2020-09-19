<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication12.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

    <table class="auto-style1">
        <tr>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td>
                            <table class="auto-style1">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="Label">User</asp:Label>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="Label">Pass</asp:Label>
                                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                        <br />
                                        <asp:Label ID="Label3" runat="server" Text="Sai roi nhe!"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
