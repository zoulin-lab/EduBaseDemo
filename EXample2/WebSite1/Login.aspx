<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            width: 454px;
            height: 281px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">

    <table class="auto-style10">
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center">登录</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:right">用户名：</td>
            <td style=" text-align:center">
                <asp:TextBox ID="txtName" runat="server" Width="214px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfyName" ControlToValidate="txtName" Display="Dynamic" runat="server" ErrorMessage="必填" runat="server" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">密码：</td>
            <td style="text-align:center">
                <asp:TextBox ID="txtPassword" runat="server" Width="213px" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfyPassword"  ControlToValidate="txtPassword" Display="Dynamic"  runat="server" ErrorMessage="必填" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center">
                <asp:Button ID="btnLogin" runat="server" Text="登录" Width="71px" OnClick="btnLogin_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:right;">
                <asp:LinkButton ID="LinkButton8" runat="server" ForeColor="#0066CC" style="text-decoration:none" CausesValidation="False" PostBackUrl="~/NewUser.aspx">我要注册</asp:LinkButton>
            </td>
            <td style="text-align:center">
                <asp:LinkButton ID="LinkButton9" runat="server" ForeColor="#0066CC" style="text-decoration:none" CausesValidation="False" PostBackUrl="~/GetPassword.aspx">忘记密码？</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center">
                <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>

