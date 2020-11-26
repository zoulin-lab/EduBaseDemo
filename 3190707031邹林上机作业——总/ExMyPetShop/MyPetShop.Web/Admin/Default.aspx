<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Styles/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
          <header class ="header">
           <asp:Image ID="imgLogo" runat="server" ImgeUrl="~/Images/logo.gif" ImageUrl="~/Images/logo.gif"/>
           <ul class ="nav nav-pills">
               <li class ="navDark">
                   <asp:LinkButton ID="lnkbtnDefault" ForeColor="White" runat="server" CausesValidation="False" PostBackUrl="~/Default.aspx">首页</asp:LinkButton>
               </li>
               <li class ="navDark">
                   <asp:LinkButton ID="lnkbtnRegister" ForeColor="White" runat="server" CausesValidation="False">注册</asp:LinkButton>
               </li>
               <li class ="navDark">
                   <asp:LinkButton ID="lnkbtnLogin" ForeColor="White" runat="server" CausesValidation="False">登录</asp:LinkButton>
               </li>
               <li class ="navDark">
                   <asp:LinkButton ID="lnkbtnCart" ForeColor="White" runat="server" CausesValidation="False" PostBackUrl="~/ShopCart.aspx">购物车</asp:LinkButton>
               </li>
               <li class ="navDark">
                   <asp:LinkButton ID="lnkbtnSiteMap" ForeColor="White" runat="server" CausesValidation="False" PostBackUrl="~/Map.aspx">网站地图</asp:LinkButton>
               </li>
            </ul>
           <div class ="status">
               <asp:Label ID="lblWelcome" runat="server" Text="您还未登录！"></asp:Label>
               <asp:LinkButton ID="lnkbtnPwd" runat="server" CausesValidation="False" ForeColor="White" PostBackUrl="~/ChangePwd.aspx" Visible="False">密码修改</asp:LinkButton>
               <asp:LinkButton ID="lnkbtnManange" runat="server" ForeColor="White" PostBackUrl="~/Admin/Default.aspx" Visible="False">系统管理</asp:LinkButton>
               <asp:LinkButton ID="lnkbtnOrder" runat="server" CausesValidation="False" ForeColor="White" PostBackUrl="~/OrderList.aspx" Visible="False">购物记录</asp:LinkButton>
               <asp:LinkButton ID="lnkbtnLogout" runat="server" CausesValidation="False" ForeColor="White" Visible="False">退出登录</asp:LinkButton>
               </div>
       </header>
       <nav class ="sitemap">
           您的位置：
       </nav>
        <section class="mainbody">
         <p>
            分类名：<asp:DropDownList ID="ddl_Category" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="CategoryId" OnSelectedIndexChanged="ddl_Category_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <asp:GridView ID="gv_Product" runat="server" AllowPaging="True" AutoGenerateColumns="False" PageSize="1" Height="274px" OnSelectedIndexChanging="gv_Product_PageIndexChanging" Width="555px">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style3" rowspan="4">
                                    <asp:Image ID="img_Product" runat="server" ImageUrl='<%# Bind("Image") %>' Height="87px" Width="119px" />
                                </td>
                                <td class="auto-style8">商品名称：</td>
                                <td>
                                    <asp:Label ID="lbl_Name" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">商品价格：</td>
                                <td>
                                    <asp:Label ID="lbl_ListPrice" runat="server" Text='<%# Bind("ListPrice") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">商品描述：</td>
                                <td class="auto-style5">
                                    <asp:Label ID="lbl_Descn" runat="server" Text='<%# Bind("Descn") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">库存：</td>
                                <td class="auto-style5">
                                    <asp:Label ID="lbl_Qty" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="~/ShopCart.aspx?ProductId={0}" HeaderText="放入购物车" Text="购买" />
            </Columns>
            <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPrevious" NextPageText="下一页" Position="TopAndBottom" PreviousPageText="上一页" />
        </asp:GridView>
        </section>
    </form>
</body>
</html>
