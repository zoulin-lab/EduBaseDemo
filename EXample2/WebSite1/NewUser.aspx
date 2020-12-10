<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewUser.aspx.cs" Inherits="NewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
            background-color:rgba(51, 159, 203, 0.34)
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">

    <table class="auto-style9">
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center">注册</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:right">用户名：</td>
            <td style="text-align:center">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="必填" ForeColor="#FF3300" ControlToValidate="txtName" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">邮箱：</td>
            <td style="text-align:center">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="必填" ForeColor="#FF3300" ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center">
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="邮箱格式不正确！" ForeColor="#FF3300" ControlToValidate="txtEmail" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:right">密码：</td>
            <td style="text-align:center">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="必填" ForeColor="#FF3300" ControlToValidate="txtPassword" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">确认密码：</td>
            <td style="text-align:center">
                <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ErrorMessage="必填" ForeColor="#FF3300" ControlToValidate="txtConfirmPassword" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center">
                <asp:CompareValidator ID="cvPassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="2次密码不一致！" ForeColor="#FF3300"></asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center">
                <asp:Button ID="btnRegister" runat="server" Text="立即注册" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:right">
                <asp:LinkButton ID="lkbLogin" runat="server" ForeColor="#0066CC" style="text-decoration:none" PostBackUrl="~/Login.aspx" CausesValidation="False">我要登录</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:right">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>

