<%@ Page Language="C#" AutoEventWireup="true" CodeFile="week_11_homework_2.aspx.cs" Inherits="Week_11_homework_week_11_homework_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            查询商品信息表中“ListPrice”属性低于这个数字的记录<br />
            <asp:TextBox ID="txt_Lmilt" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="btn_Select" runat="server" Text="查询" OnClick="btn_Select_Click" />
        </div>
        <asp:GridView ID="gv_Product" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
