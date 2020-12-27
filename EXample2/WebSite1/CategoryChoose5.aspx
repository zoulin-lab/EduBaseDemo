<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CategoryChoose5.aspx.cs" Inherits="CategoryChoose5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <asp:GridView ID="gvProduct" BackColor="#f0f0f0" runat="server" AllowPaging="True" AutoGenerateColumns="false" OnPageIndexChanging="gvProduct_PageIndexChanging" PagerSettings-Mode="NextPrevious" PageSize="2" Width="674px" Height="16px">
      <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" PreviousPageText="上一页" />
      <Columns>
        <asp:TemplateField>
          <ItemTemplate >
            <table style="border: 0.5px solid #808080; width: 100%;" >
              <tr>
                <td style="border-style: none; border-color: inherit; border-width: 1px; text-align: center; vertical-align: middle; " rowspan="7" class="auto-style15">
                  <asp:Image ID="imgImage" runat="server" ImageUrl='<%# Bind("Image") %>' Height="100px" Width="100px" />
                </td>
                <td style="border: 0.5px solid #808080; " class="auto-style14">商品编号： </td>
                <td style="border: 0.5px solid #808080; " class="auto-style13">
                  <asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'></asp:Label>
                </td>
              </tr>
              <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style14">商品名称： </td>
                <td style="border: 0.5px solid #808080;" class="auto-style13">
                  <asp:Label ID="lblName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                </td>
              </tr>
                <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style14">商品描述： </td>
                <td style="border: 0.5px solid #808080;" class="auto-style13">
                  <asp:Label ID="Label1" runat="server" Text='<%# Bind("Descn") %>'></asp:Label>
                </td>
              </tr>
                <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style14">配送时间：</td>
                <td style="border: 0.5px solid #808080;" class="auto-style13">
                  <asp:Label ID="Label2" runat="server" Text='<%# Bind("DeliveryTime") %>'></asp:Label>
                </td>
              </tr>
              <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style14">商品价格</td>
                <td style="border: 0.5px solid #808080;" class="auto-style13">
                  <asp:Label ID="lblListPrice" runat="server" Text='<%# Bind("ListPrice") %>'></asp:Label>
                </td>
              </tr>
              <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style14">月销： </td>
                <td style="border: 0.5px solid #808080;" class="auto-style13">
                  <asp:Label ID="lblQty" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
                </td>
              </tr>
            </table>
          </ItemTemplate>
        </asp:TemplateField>
        <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ShopCart.aspx?ProductId={0}" DataTextFormatString="{0:c}" HeaderText="放入购物车" Text="购买" />
      </Columns>
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

