<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QuanLyQuyen.aspx.cs" Inherits="WebApplication12.QuanLyQuyen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

    <asp:GridView ID="GridView1" runat="server" Height="95px" Width="170px">
    </asp:GridView>
    <table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Ma"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Ten"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="add" />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Ma"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Xoa" />
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Ma"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Ten"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sua" />
            <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
