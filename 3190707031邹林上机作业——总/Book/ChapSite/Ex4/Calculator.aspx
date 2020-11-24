<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculator.aspx.cs" Inherits="Ex4_Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: left">
            简易计算器</div>
        <asp:TextBox ID="txtDisplay" runat="server" ReadOnly="True" Width="110px"></asp:TextBox>
        <p>
            <asp:Button ID="btnOne" runat="server" OnClick="btnOne_Click" Text="1" Width="40px" />
            <asp:Button ID="btnTwo" runat="server" OnClick="btnTwo_Click" Text="2" Width="40px" />
            <asp:Button ID="btnThree" runat="server" OnClick="btnThree_Click" Text="3" Width="40px" />
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" CssClass="auto-style1" OnClick="btnAdd_Click" Text="+" Width="40px" />
            <asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="-" Width="40px" />
            <asp:Button ID="btnEqual" runat="server" OnClick="btnEqual_Click" Text="=" Width="40px" />
        </p>
    </form>
</body>
</html>
