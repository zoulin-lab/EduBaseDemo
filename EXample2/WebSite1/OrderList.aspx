<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<%@ Register src="UserControl/Supplier.ascx" tagname="Supplier" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 100%;
        }
        .auto-style11 {
            width: 362px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <asp:GridView ID="gvOrderItem" runat="server" AutoGenerateColumns="False" Width="879px">
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
    
    <table class="auto-style10">
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td style="text-align:center">
                <uc1:Supplier ID="Supplier1" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

