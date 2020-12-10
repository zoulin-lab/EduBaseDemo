<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChooseService.aspx.cs" Inherits="ChooseService" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style10 {
        width: 172px;
    }
    .auto-style11 {
        width: 217%;
        background-color:rgba(51, 159, 203, 0.34);
    }
        .auto-style14 {
            height: 43px;
            text-align: center;
            color: #0575ab;
            background-color:#1ebfd5
        }
        .auto-style15 {
            height: 53px;
            font-size:34px;
            text-align:center;
            color:#0575ab;
        }
        .auto-style17 {
            width: 111px;
        }
        .auto-style18 {
            height: 43px;
            text-align: center;
            color: #0575ab;
            width: 92px;
        }
        .auto-style19 {
            width: 60px;
            color:red
        }
        .auto-style20 {
            width: 60px;
            color:red;
            font-size:35px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" Runat="Server">
    <table class="auto-style11">
    <tr>
        <td colspan="13" style="text-align:center" class="auto-style15">功能选择页</td>
    </tr>
    <tr >
        <td class="auto-style20">★</td>
        <td class="auto-style14">美食配送</td>
        <td class="auto-style14"></td>
        <td class="auto-style14">奶茶配送</td>
        <td class="auto-style14"></td>
        <td class="auto-style14">甜点配送</td>
        <td class="auto-style14"></td>
        <td class="auto-style14">零食配送</td>
        <td class="auto-style14"></td>
        <td class="auto-style14">水果配送</td>
        <td class="auto-style14">&nbsp;</td>
        <td class="auto-style14">生活用品配送</td>
        <td class="auto-style17">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style19">
            点击图片即可选择服务类别</td>
        <td class="auto-style10">
            <asp:ImageButton ID="ImageButton5" runat="server" Height="170px" ImageUrl="~/Images/美食.jpg" Width="173px" />
        </td>
        <td>&nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButton2" runat="server" Height="170px" ImageUrl="~/Images/奶茶2.jpg" Width="173px" />
        </td>
        <td>&nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButton3" runat="server" Height="170px" ImageUrl="~/Images/甜点.jpg" Width="173px" />
        </td>
        <td>&nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButton4" runat="server" Height="170px" ImageUrl="~/Images/零食.jpg" Width="173px" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="170px" ImageUrl="~/Images/水果2.jpg" Width="173px" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButton6" runat="server" Height="170px" ImageUrl="~/Images/生活用品.jpg" Width="188px" />
        </td>
        <td class="auto-style17">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style19">
            &nbsp;</td>
        <td class="auto-style10">
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="auto-style17">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphLeft2" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphRight2" Runat="Server">
</asp:Content>

