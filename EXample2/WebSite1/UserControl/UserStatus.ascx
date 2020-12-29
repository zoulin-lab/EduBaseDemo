<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserStatus.ascx.cs" Inherits="UserControl_UserStatus" %>

<asp:Label ID="lblWelcome" ForeColor="#006699" runat="server" Text="您还未登录！"></asp:Label>
<asp:LinkButton ID="lnkbtnPwd" runat="server" ForeColor="#0099ff" Visible="False" PostBackUrl="~/ChangePassword.aspx" Style="text-decoration:none" CausesValidation="False" >密码修改</asp:LinkButton>
<asp:LinkButton ID="lnkbtnManage" runat="server" ForeColor="#0099ff" Visible="False" Style="text-decoration:none" CausesValidation="False" PostBackUrl="~/Admin/CategoryMaster.aspx" >系统管理</asp:LinkButton>
<asp:LinkButton ID="lnkbtnSelect" runat="server" ForeColor="#0099ff" Visible="False" PostBackUrl="~/OrderList.aspx" Style="text-decoration:none" CausesValidation="False">已购信息</asp:LinkButton>
<asp:LinkButton ID="lnkbtnLogout" runat="server" ForeColor="#0099ff" Visible="False" OnClick="lnkbtnLogout_Click" Style="text-decoration:none" CausesValidation="False">退出登录</asp:LinkButton>