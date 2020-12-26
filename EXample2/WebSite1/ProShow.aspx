<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProShow.aspx.cs" Inherits="ProShow" %>

<%@ Register Src="~/UserControl/Supplier.ascx" TagPrefix="uc1" TagName="Supplier" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            margin-left: 0px;
            margin-right: 0px;
        }
        .auto-style11 {
            width: 38%;
        }
        .auto-style12 {
            width: 20%;
        }
        .auto-style15 {
            width: 60%;
        }
        .auto-style16 {
            width: 377px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
<uc1:Supplier runat="server" id="Supplier" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
    <table>
        <tr>
            <td class="auto-style16">
<asp:GridView ID="gvProduct" runat="server" AllowPaging="True" AutoGenerateColumns="false" OnPageIndexChanging="gvProduct_PageIndexChanging" PagerSettings-Mode="NextPrevious" PageSize="2" Width="158%" CssClass="auto-style10" Height="16px">
    <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
    <Columns>
      <asp:TemplateField>
        <ItemTemplate>
          <table style="border: 1px solid #808080; width: 100%;">
            <tr>
              <td rowspan="7" style="border-style: none; border-color: inherit; border-width: 1px; text-align: center; vertical-align: middle; " class="auto-style12">
                <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Bind("Image") %>' Height="100px" Width="100px" />
              </td>
              <td style="border: 1px solid #808080; " class="auto-style11">商品编号： </td>
              <td style="border: 1px solid #808080; " class="auto-style15">
                <asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #808080;" class="auto-style11">商品分类： </td>
              <td style="border: 1px solid #808080;" class="auto-style15">
                <asp:Label ID="lblCategoryId" runat="server" Text='<%# Bind("CategoryId") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #808080;" class="auto-style11">商品名称： </td>
              <td style="border: 1px solid #808080;" class="auto-style15">
                <asp:Label ID="lblName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #808080;" class="auto-style11">商品价格： </td>
              <td style="border: 1px solid #808080;" class="auto-style15">
                <asp:Label ID="lblListPrice" runat="server" Text='<%# Bind("ListPrice") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #808080;" class="auto-style11">商品描述： </td>
              <td style="border: 1px solid #808080;" class="auto-style15">
                <asp:Label ID="lblUnitCost" runat="server" Text='<%# Bind("Descn") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #808080;" class="auto-style11">配送时间： </td>
              <td style="border: 1px solid #808080;" class="auto-style15">
                <asp:Label ID="lblDescn" runat="server" Text='<%# Bind("DeliveryTime") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td style="border: 1px solid #808080;" class="auto-style11">月销： </td>
              <td style="border: 1px solid #808080;" class="auto-style15">
                <asp:Label ID="lblQty" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
              </td>
            </tr>
          </table>
        </ItemTemplate >
      </asp:TemplateField>
      <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ShopCart.aspx?ProductId={0}" DataTextFormatString="{0:c}" HeaderText="放入购物车" Text="购买" />
    </Columns>
  </asp:GridView>
            </td>
        </tr>
    </table>
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

