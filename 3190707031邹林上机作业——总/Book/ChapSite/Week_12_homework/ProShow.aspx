<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProShow.aspx.cs" Inherits="Week_12_homework_ProShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 134px;
        }
        .auto-style5 {
            height: 20px;
        }
    .auto-style6 {
        width: 240px;
    }
    .auto-style7 {
        width: 240px;
        height: 20px;
    }
    .auto-style8 {
        width: 158px;
    }
    .auto-style9 {
        width: 158px;
        height: 20px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
