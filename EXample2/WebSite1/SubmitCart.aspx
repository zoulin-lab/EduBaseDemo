<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SubmitCart.aspx.cs" Inherits="SubmitCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            width: 115%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
     <asp:Panel ID="pnlConsignee" runat="server" Height="286px" Width="689px">
    <table style="width: 100%; border: 2px solid #fff;">
      <tr>
        <td style="text-align: center;" colspan="2">
          <strong>填写发货地址</strong>
        </td>
      </tr>
      <tr>
        <td style="width: 30%; text-align: right;">送货地址：
        </td>
        <td class="auto-style11">
          <asp:TextBox ID="txtAddr1" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvAddr1" runat="server" ErrorMessage="不能为空" ControlToValidate="txtAddr1"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align: right;">发票寄送地址：
        </td>
        <td class="auto-style11">
          <asp:TextBox ID="txtAddr2" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvAddr2" runat="server" ControlToValidate="txtAddr2" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align: right;">城市：
        </td>
        <td class="auto-style11">
          <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align: right;">省（自治区、直辖市）：
        </td>
        <td class="auto-style11">
          <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="txtState" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align: right;">联系电话：
        </td>
        <td class="auto-style11">
          <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align: right;">&nbsp;
        </td>
        <td class="auto-style11">
          <asp:Button ID="btnSubmit" runat="server" Text="提交结算" OnClick="btnSubmit_Click" />
        </td>
      </tr>
    </table>
  </asp:Panel>
  <asp:Label ID="lblMsg" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

