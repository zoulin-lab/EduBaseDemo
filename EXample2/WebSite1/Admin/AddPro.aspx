<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddPro.aspx.cs" Inherits="Admin_AddPro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 113%;
        }
        .auto-style11 {
            width: 19%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <div style="text-align:center">
  <a href="CategoryMaster.aspx" style="text-decoration:none">分类管理</a>
  <br />
  <br />
  <a href="SupplierMaster.aspx"  style="text-decoration:none">供应商管理</a>
  <br />
  <br />
  <a href="ProductMaster.aspx"  style="text-decoration:none">商品管理</a>
  <br />
  <br />
  <a href="OrderMaster.aspx"  style="text-decoration:none">订单管理</a>
  <br />
  <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
    <asp:Panel ID="pnlProductMaster" runat="server">
    <table style="width:100%; border:4px solid #fff;">
      <tr>
        <td style="text-align:center; " colspan="2">
          <strong>添加商品</strong>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">商品名称:
        </td>
        <td class="auto-style10">
          <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
          <asp:Label ID="lblNameErr" runat="server"
            ForeColor="Red"></asp:Label>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">商品分类:
        </td>
        <td class="auto-style10">
          <asp:DropDownList ID="ddlCategoryId" runat="server">
          </asp:DropDownList>
          <asp:RequiredFieldValidator ID="rfvCategoryId" runat="server" ControlToValidate="ddlCategoryId"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">商品单价:
        </td>
        <td class="auto-style10">
          <asp:TextBox ID="txtListPrice" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvListPrice" runat="server" ControlToValidate="txtListPrice"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">单位成本:
        </td>
        <td class="auto-style10">
          <asp:TextBox ID="txtUnitCost" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvUnitCost" runat="server" ControlToValidate="txtUnitCost"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">提供商:
        </td>
        <td class="auto-style10">
          <asp:DropDownList ID="ddlSuppId" runat="server">
          </asp:DropDownList>
          <asp:RequiredFieldValidator ID="rfvSuppId" runat="server" ControlToValidate="ddlSuppId"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">描述:
        </td>
        <td class="auto-style10">
          <asp:TextBox ID="txtDescn" runat="server" Height="42px" TextMode="MultiLine"
            Width="263px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvDescn" runat="server" ControlToValidate="txtDescn"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">月销:
        </td>
        <td class="auto-style10">
          <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvQty" runat="server" ControlToValidate="txtQty"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">商品图片:
        </td>
        <td class="auto-style10">
          <asp:FileUpload ID="fupImage" runat="server" />
          <asp:RequiredFieldValidator ID="rfvImage" runat="server" ControlToValidate="fupImage"
            ErrorMessage="不能为空"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td style="text-align:right; " class="auto-style11">&nbsp;
        </td>
        <td class="auto-style10">
          <asp:Button ID="btnAdd" runat="server" Text="添加商品" OnClick="btnAdd_Click" />
        </td>
      </tr>
    </table>
  </asp:Panel>
  <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

