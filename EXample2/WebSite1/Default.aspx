<%@ Page Title="首页" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/UserControl/NewProduct.ascx" TagPrefix="uc" TagName="NewProduct" %>
<%@ Register Src="~/UserControl/HotProduct.ascx" TagPrefix="uc" TagName="HotProduct" %>
<%@ Register Src="~/UserControl/DiscountProduct.ascx" TagPrefix="uc" TagName="DiscountProduct" %>
<%@ Register Src="~/UserControl/AutoPro.ascx" TagPrefix="uc" TagName="AutoPro" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="upNewProduct" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
      <p style="font-size:larger;color:#2471f5;">最新商品</p>
        <uc:NewProduct runat="server" ID="NewProduct" title="最新商品" />
       </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
      <p style="font-size:larger;color:#2471f5">热销商品</p>
        <uc:HotProduct runat="server" ID="HotProduct" title="热销商品" />
       </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
      <p style="font-size:larger;color:#2471f5">折扣商品</p>
        <uc:DiscountProduct runat="server" ID="DiscountProduct" title="折扣商品" />
       </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
      <p style="font-size:larger;color:#2471f5">商品详细</p>
        <uc:AutoPro runat="server" ID="AutoPro"  title="商品详细"/>
       </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>

