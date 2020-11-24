<%@ Page Language="C#" AutoEventWireup="true" CodeFile="week_11_homework_1.aspx.cs" Inherits="Week_11_homework_week_11_homework_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            查询商品名字中有字符c且价格在30元以上的商品<br />
            <asp:Button ID="btn_Select" runat="server" Text="查询"  OnClick="btn_Select_Click"/>
            <asp:GridView ID="gv_Product" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
