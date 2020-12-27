<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SelectPage.aspx.cs" Inherits="SelectPage" %>

<%@ Register src="UserControl/QtySupplier.ascx" tagname="QtySupplier" tagprefix="uc2" %>
<%@ Register Src="~/UserControl/ScoreSupplier.ascx" TagPrefix="uc1" TagName="ScoreSupplier" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 122%;
            height: 43px;
            background-color:#becbce
        }
        .auto-style11 {
            width: 251px;
            text-align:center;
            height: 25px;
        }
        .auto-style12 {
            width: 183px;
            height: 25px;
            text-align:right
        }
        .auto-style13 {
            height: 25px;
            width: 196px;
        }
        .auto-style14 {
            width: 828px;
        }
        .auto-style16 {
            width: 676px;
            height: 40px;
        }
        .auto-style17 {
            width: 211px;
        }
        .auto-style18 {
            width: 211px;
            height: 25px;
            font-size:large
        }
        .auto-style20 {
            width: 241px;
            top: 0px;
        }
        .auto-style21 {
            width: 241px;
            height: 25px;
            font-size: large;
        }
        .auto-style24 {
            width: 125px;
            font-size: large;
        }
        .auto-style25 {
            width: 672px;
            height: 432px;
        }
        .auto-style26 {
            width: 29%;
        }
        .auto-style27 {
            width: 146px;
        }
        .auto-style28 {
            width: 239px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
            <table class="auto-style10">
                <tr>
                    <td class="auto-style12" >
                        <asp:Image ID="Image3" runat="server" Height="26px" ImageUrl="~/Images/google_logo.gif" Width="79px" />
                    </td>
                    <td class="auto-style11">            
                        <asp:TextBox ID="txtSearch" runat="server" CssClass="auto-style4" Width="227px"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
            <asp:ImageButton ID="imgbtnSearch" runat="server" ImageUrl="~/Images/searchbutton.gif" CausesValidation="False" OnClick="imgbtnSearch_Click" Height="27px"  />
                    </td>
                </tr>
            </table>
         
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
    <table class="auto-style16">
        <tr>
            <td class="auto-style24" rowspan="2" >
                &nbsp;</td>
            <td class="auto-style18" >
                高评分</td>
            <td class="auto-style21">
                高月销</td>
        <tr>
            <td style="color:black" class="auto-style17"  >
                <uc1:ScoreSupplier runat="server" ID="ScoreSupplier" />
            </td>
            <td class="auto-style20">
            <uc2:QtySupplier ID="QtySupplier1" runat="server" />
            </td>
        </tr>
    </table>

    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
    <table class="auto-style25">
      <tr>
          <td class="auto-style14" style="text-align:center">
   <asp:GridView ID="gvProduct" Font-Size="Small" runat="server" AllowPaging="True" AutoGenerateColumns="false" OnPageIndexChanging="gvProduct_PageIndexChanging" PagerSettings-Mode="NextPrevious" PageSize="2" Width="100%" Height="16px">
    <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
    <Columns>
      <asp:TemplateField>
        <ItemTemplate>
          <table >
            <tr>
              <td style="text-align: center;font-size:small; vertical-align: middle; " rowspan="7" class="auto-style26">
                <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Bind("Image") %>' />
              </td>
              <td class="auto-style27" >商品编号： </td>
              <td class="auto-style28" >
                <asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td class="auto-style27" >商品分类： </td>
              <td class="auto-style28" >
                <asp:Label ID="lblCategoryId" runat="server" Text='<%# Bind("CategoryId") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td class="auto-style27" >商品名称： </td>
              <td class="auto-style28" >
                <asp:Label ID="lblName" runat="server" ForeColor="Red" Text='<%# Bind("ProductName") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td class="auto-style27" >商品价格： </td>
              <td class="auto-style28" >
                <asp:Label ID="lblListPrice" runat="server" Text='<%# Bind("ListPrice") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td class="auto-style27" >商品描述： </td>
              <td class="auto-style28" >
                <asp:Label ID="lblUnitCost" runat="server" Text='<%# Bind("Descn") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td class="auto-style27" >配送时间： </td>
              <td class="auto-style28" >
                <asp:Label ID="lblDescn" runat="server" Text='<%# Bind("DeliveryTime") %>'></asp:Label>
              </td>
            </tr>
            <tr>
              <td class="auto-style27" >月销： </td>
              <td class="auto-style28" >
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

