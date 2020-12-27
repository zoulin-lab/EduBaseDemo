<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderSub.aspx.cs" Inherits="OrderSub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            height: 24px;
            width: 24%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
    订单主表
  <asp:GridView ID="gvOrder" runat="server" AutoGenerateColumns="false"
    Width="100%" PageSize="1">
    <Columns>
      <asp:TemplateField>
        <ItemTemplate>
          <table style="width: 100%; border: 1px solid #ccc;">
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">订单ID：
              </td>
              <td style="width: 80%;">
                <asp:Label ID="lblOrderId" runat="server" Text='<%# Bind("OrderId") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">客户名称：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblUserName" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">订购时间：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblOrderDate" runat="server" Text='<%# Bind("OrderDate") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">地址1：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblAddr1" runat="server" Text='<%# Bind("Address1") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">地址2：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblAddr2" runat="server" Text='<%# Bind("Address2") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">城市：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">区域：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblState" runat="server" Text='<%# Bind("State") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">手机：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblPhone" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #ccc; text-align: right;" class="auto-style10">审核状态：
              </td>
              <td style="border: 1px solid #ccc; height: 24px;">
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
              </td>
            </tr>
          </table>
        </ItemTemplate>
      </asp:TemplateField>
    </Columns>
  </asp:GridView>
  购买详细
  <asp:GridView ID="gvOrderItem" runat="server" Width="100%" AllowPaging="True" OnPageIndexChanging="gvOrderItem_PageIndexChanging"
    PagerSettings-Mode="NextPrevious" CellPadding="4" ForeColor="#333333"
    GridLines="None" AutoGenerateColumns="False">
    <PagerSettings FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
    <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
    <RowStyle BackColor="#E3EAEB" />
    <Columns>
      <asp:TemplateField>
        <ItemTemplate>
          <asp:Image ID="imgArrow" runat="server" ImageUrl="~/Images/arrow.gif" />
        </ItemTemplate>
      </asp:TemplateField>
      <asp:BoundField DataField="ItemId" HeaderText="序列号" />
      <asp:BoundField DataField="OrderId" HeaderText="订单号" />
      <asp:BoundField DataField="ProductName" HeaderText="商品名称" />
      <asp:BoundField DataField="ListPrice" HeaderText="商品单价" />
      <asp:BoundField DataField="Qty" HeaderText="购买数量" />
      <asp:BoundField DataField="TotalPrice" HeaderText="总价" />
    </Columns>
    <PagerStyle BackColor="#ffffff" HorizontalAlign="Left" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#ccccd4" Font-Bold="True" ForeColor="Black" />
    <EditRowStyle BackColor="#7C6F57" />
    <AlternatingRowStyle BackColor="White" />
  </asp:GridView>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

