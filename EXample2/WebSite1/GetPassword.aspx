<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GetPassword.aspx.cs" Inherits="GetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style21 {
            height: 18px;
        }
        .auto-style22 {
            width: 239px;
            height: 18px;
            text-align: center;
        }
        .auto-style23 {
            width: 608px;
        }
        .auto-style24 {
            width: 343px;
            text-align:center
        }
        .auto-style28 {
            width: 239px;
            height: 4px;
            text-align: center;
        }
        .auto-style29 {
            width: 343px;
            text-align: center;
            height: 4px;
        }
        .auto-style30 {
            height: 4px;
        }
        .auto-style31 {
            height: 46px;
        }
        .auto-style32 {
            width: 239px;
            height: 46px;
            text-align: left;
        }
        .auto-style33 {
            width: 343px;
            height: 46px;
            text-align: center;
        }
    .auto-style34 {
        height: 43px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <table style="border-collapse: collapse;" class="auto-style23">
        <tr>
          <td  colspan="3"  style="text-align:center" class="auto-style34">找回密码</td>
        </tr>
        <tr>
          <td class="auto-style32" style="text-align:right">用户名:</td>
          <td class="auto-style33">
            <asp:TextBox ID="txtName" runat="server" CssClass="auto-style12" Width="214px"></asp:TextBox></td>
          <td class="auto-style32">
            <asp:RequiredFieldValidator ControlToValidate="txtName" Display="Dynamic" ForeColor="Red" ID="rfvName" runat="server" ErrorMessage="必填"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
          <td class="auto-style32" style="text-align:right">邮箱:</td>
          <td class="auto-style33">
            <asp:TextBox ID="txtEmail" runat="server" Width="214px"></asp:TextBox></td>
          <td class="auto-style32">
            <asp:RequiredFieldValidator ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red" ID="rfvEmail" runat="server" ErrorMessage="必填"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
          <td class="auto-style28">
              </td>
          <td style="text-align:center" class="auto-style29">
            <asp:RegularExpressionValidator ID="revEmail" runat="server"
              ErrorMessage="邮箱格式不正确！" ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
          </td>
          <td class="auto-style30">
              </td>
        </tr>
        <tr>
          <td class="auto-style32">
              </td>
          <td class="auto-style33">
            <asp:Button ID="btnResetPwd" runat="server" Text="找回密码" OnClick="btnResetPwd_Click"  />
          </td>
          <td class="auto-style31">
              </td>
        </tr>
        <tr>
          <td class="auto-style22"></td>
          <td class="auto-style24" style="color:#0066CC">找回密码，需要验证邮箱！</td>
          <td class="auto-style21"></td>
        </tr>
        <tr>
          <td  class="auto-style22">
              </td>
          <td  class="auto-style24">
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label></td>
          <td  class="auto-style22">
              </td>
        </tr>
      </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

