<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewUser.aspx.cs" Inherits="NewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            height: 36px;
        }
    .auto-style11 {
        height: 46px;
    }
    .auto-style12 {
        height: 43px;
    }
    .auto-style13 {
        height: 2px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">

    <table class="auto-style9">
        <tr>
            <td class="auto-style12"></td>
            <td style="text-align:center" class="auto-style12">注册</td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style11">用户名：</td>
            <td style="text-align:center" class="auto-style11">
                <asp:TextBox ID="txtName" runat="server" Width="214px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="必填" ForeColor="#FF3300" ControlToValidate="txtName" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style11">邮箱：</td>
            <td style="text-align:center" class="auto-style11">
                <asp:TextBox ID="txtEmail" runat="server" Width="214px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="必填" ForeColor="#FF3300" ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td style="text-align:center" class="auto-style13">
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="邮箱格式不正确！" ForeColor="#FF3300" ControlToValidate="txtEmail" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style11">密码：</td>
            <td style="text-align:center" class="auto-style11">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="214px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="必填" ForeColor="#FF3300" ControlToValidate="txtPassword" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style11">确认密码：</td>
            <td style="text-align:center" class="auto-style11">
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Width="214px"></asp:TextBox>
            </td>
            <td class="auto-style11" >
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
            <td class="auto-style10"></td>
            <td style="text-align:center" class="auto-style10">
                <asp:Button ID="btnRegister" runat="server" Text="立即注册" OnClick="btnRegister_Click" />
            </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td style="text-align:right">
                <asp:LinkButton ID="lkbLogin" runat="server" ForeColor="#0066CC" style="text-decoration:none" PostBackUrl="~/Login.aspx" CausesValidation="False">我要登录</asp:LinkButton>
            </td>
            <td style="text-align:center">
                <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
            </td>
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

