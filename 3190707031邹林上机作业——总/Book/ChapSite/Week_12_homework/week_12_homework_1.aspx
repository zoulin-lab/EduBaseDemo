<%@ Page Language="C#" AutoEventWireup="true" CodeFile="week_12_homework_1.aspx.cs" Inherits="Week_12_homework_week_12_homework_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_Category" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataTextField="Name" DataValueField="CategoryId" OnSelectedIndexChanged="ddl_Category_SelectedIndexChanged">
                <asp:ListItem>-请选择-</asp:ListItem>
            </asp:DropDownList>
            您选择的ID为：<asp:Label ID="lbl_Count" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:GridView ID="gv_Category" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
