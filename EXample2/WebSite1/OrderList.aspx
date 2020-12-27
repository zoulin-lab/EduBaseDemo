<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <asp:GridView ID="gvOrderItem" runat="server" AutoGenerateColumns="False" Width="1221px">
    <Columns>
      <asp:BoundField DataField="OrderId" HeaderText="订单号" />
      <asp:BoundField DataField="UserId" HeaderText="用户号" />
      <asp:BoundField DataField="UserName" HeaderText="用户名" />
      <asp:BoundField DataField="OrderDate" HeaderText="订单时间" />
      <asp:BoundField DataField="Address1" HeaderText="用户地址" />
      <asp:BoundField DataField="city" HeaderText="城市" />
      <asp:BoundField DataField="Phone" HeaderText="电话" />
      <asp:BoundField DataField="Status" HeaderText="状态" />
    </Columns>
    <HeaderStyle VerticalAlign="Middle" />
  </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

