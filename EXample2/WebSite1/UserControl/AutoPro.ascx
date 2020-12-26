<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AutoPro.ascx.cs" Inherits="UserControl_AutoPro" %>

<style type="text/css">
    .auto-style6 {
        width: 59%;
    }
    .auto-style9 {
        width: 40%;
    }
</style>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" >
  <ContentTemplate>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
      <ProgressTemplate>
        正在连接数据库服务器，请耐心等待......
      </ProgressTemplate>
    </asp:UpdateProgress>

    <asp:Timer ID="tmrAutoShow" runat="server" Interval="3000" OnTick="tmrAutoShow_Tick" Enabled="False">
    </asp:Timer>
    <asp:GridView ID="gvProduct" BackColor="#f0f0f0" runat="server" AllowPaging="True" AutoGenerateColumns="false" OnPageIndexChanging="gvProduct_PageIndexChanging" PagerSettings-Mode="NextPrevious" PageSize="1" Width="578px" Height="16px">
      <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" PreviousPageText="上一页" />
      <Columns>
        <asp:TemplateField>
          <ItemTemplate >
            <table style="border: 0.5px solid #808080; width: 100%;" >
              <tr>
                <td style="text-align: center; border: 1px; vertical-align: middle; width: 15%;" rowspan="7">
                  <asp:Image ID="imgImage" runat="server" ImageUrl='<%# Bind("Image") %>' Height="100px" Width="100px" />
                </td>
                <td style="border: 0.5px solid #808080; " class="auto-style9">商品编号： </td>
                <td style="border: 0.5px solid #808080; " class="auto-style6">
                  <asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'></asp:Label>
                </td>
              </tr>
              <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style9">商品名称： </td>
                <td style="border: 0.5px solid #808080;" class="auto-style6">
                  <asp:Label ID="lblName" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
                </td>
              </tr>
                <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style9">商品描述： </td>
                <td style="border: 0.5px solid #808080;" class="auto-style6">
                  <asp:Label ID="Label1" runat="server" Text='<%# Bind("Descn") %>'></asp:Label>
                </td>
              </tr>
                <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style9">配送时间：</td>
                <td style="border: 0.5px solid #808080;" class="auto-style6">
                  <asp:Label ID="Label2" runat="server" Text='<%# Bind("DeliveryTime") %>'></asp:Label>
                </td>
              </tr>
              <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style9">商品价格</td>
                <td style="border: 0.5px solid #808080;" class="auto-style6">
                  <asp:Label ID="lblListPrice" runat="server" Text='<%# Bind("ListPrice") %>'></asp:Label>
                </td>
              </tr>
              <tr>
                <td style="border: 0.5px solid #808080;" class="auto-style9">月销： </td>
                <td style="border: 0.5px solid #808080;" class="auto-style6">
                  <asp:Label ID="lblQty" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
                </td>
              </tr>
            </table>
          </ItemTemplate>
        </asp:TemplateField>
        <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ShopCart.aspx?ProductId={0}" DataTextFormatString="{0:c}" HeaderText="放入购物车" Text="购买" />
      </Columns>
    </asp:GridView>
    <asp:CheckBox ID="chkAutoShow" runat="server" AutoPostBack="True" Text="3秒后显示下一个商品" OnCheckedChanged="chkAutoShow_CheckedChanged" />
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="tmrAutoShow" EventName="Tick" />
  </Triggers>
</asp:UpdatePanel>

