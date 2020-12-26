<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SelectPage.aspx.cs" Inherits="SelectPage" %>

<%@ Register src="UserControl/QtySupplier.ascx" tagname="QtySupplier" tagprefix="uc2" %>
<%@ Register Src="~/UserControl/ScoreSupplier.ascx" TagPrefix="uc1" TagName="ScoreSupplier" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 83%;
            background-color:#8ac4ef;
            height: 30px;
        }
        .auto-style11 {
            width: 251px;
            text-align:left;
            height: 25px;
        }
        .auto-style12 {
            width: 41px;
            height: 25px;
        }
        .auto-style13 {
            height: 25px;
        }
        .auto-style14 {
            width: 740px;
        }
        .auto-style16 {
            width: 429px;
            height: 40px;
            background-color:#8ac4ef
        }
        .auto-style17 {
            width: 211px;
        }
        .auto-style18 {
            width: 211px;
            height: 25px;
            font-size:large
        }
        .auto-style19 {
            width: 211px;
            height: 25px;
            font-size:large
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
            <table class="auto-style10">
                <tr>
                    <td class="auto-style12" >
                        <asp:Image ID="Image3" runat="server" Height="21px" ImageUrl="~/Images/搜索.jpg" />
                    </td>
                    <td class="auto-style11">            
                        <asp:TextBox ID="txtSearch" runat="server" CssClass="auto-style4" Width="227px"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
            <asp:ImageButton ID="imgbtnSearch" runat="server" ImageUrl="~/Images/searchbutton.gif" CausesValidation="False" OnClick="imgbtnSearch_Click"  />
                    </td>
                </tr>
            </table>
         
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
    <table class="auto-style16">
        <tr>
            <td class="auto-style18" >
                高评分</td>
            <td class="auto-style19">
                高月销</td>
        <tr>
            <td style="" class="auto-style17" >
                <uc1:ScoreSupplier runat="server" ID="ScoreSupplier" />
            </td>
            <td style="top:0px" class="auto-style17">
            <uc2:QtySupplier ID="QtySupplier1" runat="server" />
            </td>
        </tr>
    </table>

    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
  <table>
      <tr>
          <td class="auto-style14" style="text-align:center">
   <asp:GridView ID="gvProduct" Font-Size="Small" runat="server" AllowPaging="True" AutoGenerateColumns="false" OnPageIndexChanging="gvProduct_PageIndexChanging" PagerSettings-Mode="NextPrevious" PageSize="2" Width="83%" Height="16px">
    <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
    <Columns>
      <asp:TemplateField>
        <ItemTemplate>
          <table >
            <tr>
              <td style="text-align: center;font-size:small; vertical-align: middle; width: 40%;" rowspan="7">
                <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Bind("Image") %>' />
              </td>
              <td >商品编号： </td>
              <td >
                <asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td >商品分类： </td>
              <td >
                <asp:Label ID="lblCategoryId" runat="server" Text='<%# Bind("CategoryId") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td >商品名称： </td>
              <td >
                <asp:Label ID="lblName" runat="server" ForeColor="Red" Text='<%# Bind("ProductName") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td >商品价格： </td>
              <td >
                <asp:Label ID="lblListPrice" runat="server" Text='<%# Bind("ListPrice") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td >商品描述： </td>
              <td >
                <asp:Label ID="lblUnitCost" runat="server" Text='<%# Bind("Descn") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td >配送时间： </td>
              <td >
                <asp:Label ID="lblDescn" runat="server" Text='<%# Bind("DeliveryTime") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td >月销： </td>
              <td >
                <asp:Label ID="lblQty" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
              </td>
            </tr>
          </table>
        </ItemTemplate>
      </asp:TemplateField>
      <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ShopCart.aspx?ProductId={0}" DataTextFormatString="{0:c}" HeaderText="放入购物车" Text="购买" />
    </Columns>
  </asp:GridView>
  <asp:Label ID="lblError" runat="server"></asp:Label>  
          </td>
      </tr>
        </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

