<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserStatus.ascx.cs" Inherits="UserControl_UserStatus" %>

<asp:Label ID="lblWelcome" ForeColor="#006699" runat="server" Text="您还未登录！"></asp:Label>
<asp:LinkButton ID="lnkbtnPwd" runat="server" ForeColor="#0099ff" Visible="False" >密码修改</asp:LinkButton>
<asp:LinkButton ID="lnkbtnManage" runat="server" ForeColor="#0099ff" Visible="False" >系统管理</asp:LinkButton>
<asp:LinkButton ID="lnkbtnOrder" runat="server" ForeColor="#0099ff" Visible="False">搜索页</asp:LinkButton>
<asp:LinkButton ID="lnkbtnLogout" runat="server" ForeColor="#0099ff" Visible="False">退出登录</asp:LinkButton>