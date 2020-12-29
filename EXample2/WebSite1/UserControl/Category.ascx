<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Category.ascx.cs" Inherits="UserControl_Category" %>
<asp:TreeView ID="TreeView1" runat="server" ExpandDepth="0">
  <Nodes>
    <asp:TreeNode SelectAction="None" Text="分类商品" Value="分类商品"></asp:TreeNode>
  </Nodes>
</asp:TreeView>