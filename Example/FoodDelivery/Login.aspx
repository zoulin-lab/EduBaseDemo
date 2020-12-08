﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            background-color:#f7d5b4;
            height: 242px;
            width: 288px;
            margin-left: 245px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/外卖图.jpg" Height="241px" Width="483px" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight1" Runat="Server" >
    <table style="border-collapse: collapse;" class="auto-style2">
    <tr>
      <td class="tdcenter" colspan="2">登录</td>
    </tr>
    <tr>
      <td class="tdright">用户名:</td>
      <td>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
      <td>
        <asp:RequiredFieldValidator ControlToValidate="txtName" Display="Dynamic" ForeColor="Red" ID="rfvName" runat="server" ErrorMessage="必填"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td class="tdright">密码:</td>
      <td>
        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox></td>
      <td>
        <asp:RequiredFieldValidator ControlToValidate="txtPwd" Display="Dynamic" ForeColor="Red" ID="rfvPwd" runat="server" ErrorMessage="必填"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td colspan="2" class="tdright">
        <asp:Button ID="btnLogin" runat="server" Text="立即登录"  />
      </td>
    </tr>
    <tr>
      <td><a href="NewUser.aspx">我要注册！</a></td>
      <td class="tdcenter"><a href="GetPwd.aspx">忘记密码？</a></td>
    </tr>
    <tr>
      <td colspan="2" class="tdright">
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
      </td>
    </tr>
  </table>    
</asp:Content>

