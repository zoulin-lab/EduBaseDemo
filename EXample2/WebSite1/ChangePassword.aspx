<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            height: 318px;
            width: 556px;
        }
        .auto-style12 {
        height: 2px;
        width: 138px;
    }
    .auto-style13 {
        width: 356px;
        text-align: center;
        height: 2px;
    }
    .auto-style14 {
        height: 36px;
        width: 138px;
    }
    .auto-style15 {
        width: 356px;
        text-align: center;
        height: 36px;
    }
    .auto-style19 {
        height: 63px;
        width: 138px;
    }
    .auto-style20 {
        width: 356px;
        text-align: center;
        height: 63px;
    }
    .auto-style21 {
        width: 138px;
        height: 46px;
    }
    .auto-style22 {
        width: 356px;
        text-align: center;
        height: 46px;
    }
    .auto-style23 {
        height: 46px;
    }
    .auto-style24 {
        width: 138px;
        height: 43px;
    }
    .auto-style25 {
        width: 356px;
        text-align: center;
        height: 43px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <table style="border-collapse: collapse;" class="auto-style10">
    <tr>
      <td class="auto-style24" style="text-align:center"></td>
      <td class="auto-style25" style="text-align:center">修改密码</td>
    </tr>
    <tr>
      <td class="auto-style21" style="text-align:right">原密码:</td>
      <td class="auto-style22">
        <asp:TextBox ID="txtOldPwd" runat="server" TextMode="Password" Width="214px" ></asp:TextBox></td>
      <td class="auto-style23">
        <asp:RequiredFieldValidator ControlToValidate="txtOldPwd" Display="Dynamic" ForeColor="Red" ID="rfvOldPwd" runat="server" ErrorMessage="必填">
        </asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td class="auto-style21" style="text-align:right">新密码:</td>
      <td class="auto-style22">
        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="214px" ></asp:TextBox></td>
      <td class="auto-style23">
        <asp:RequiredFieldValidator ControlToValidate="txtPwd" Display="Dynamic" ForeColor="Red" ID="rfvPwd" runat="server" ErrorMessage="必填">
        </asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td class="auto-style21" style="text-align:right">确认新密码:</td>
      <td class="auto-style22">
        <asp:TextBox ID="txtPwdAgain" runat="server" TextMode="Password" Width="214px" ></asp:TextBox></td>
      <td class="auto-style23">
        <asp:RequiredFieldValidator ControlToValidate="txtPwdAgain" Display="Dynamic" ForeColor="Red" ID="rfvPwdAgain" runat="server" ErrorMessage="必填">
        </asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td class="auto-style12">
          </td>
      <td class="auto-style13">
        <asp:CompareValidator ControlToValidate="txtPwdAgain" ControlToCompare="txtPwd" Display="Dynamic" ForeColor="Red" ID="cvPwd" runat="server" ErrorMessage="2次新密码不一致"></asp:CompareValidator>
      </td>
    </tr>
    <tr>
      <td class="auto-style14">
          </td>
      <td class="auto-style15">
        <asp:Button ID="btnChangePwd" runat="server" Text="确认修改" OnClick="btnChangePwd_Click"  />
      </td>
    </tr>
    <tr>
      <td class="auto-style19">
          </td>
      <td class="auto-style20">
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
  </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

