<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Button.aspx.cs" Inherits="XuRunjing0221WebApplication.Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonEx" runat="server" CommandName="BottonEX" OnClick="ButtonEx_Click" OnCommand="ButtonEx_Command" Text="Normal Button" />
        <p>
            <asp:LinkButton ID="LinkButtonEx" runat="server" CommandName="LinkButtonEx" OnClick="ButtonEx_Click" OnCommand="ButtonEx_Command">Link Button</asp:LinkButton>
        </p>
        <asp:ImageButton ID="ImageButtonEx" runat="server" CommandName="ImageButtonEx" Height="173px" ImageUrl="~/QQ图片20220402200533.png" OnClick="ButtonEx_Click" OnCommand="ButtonEx_Command" Width="183px" />
        <p>
            <asp:Label ID="LabelMessage" runat="server" Text="LabelMessage"></asp:Label>
        </p>
        <asp:Label ID="LableClick" runat="server" Text="LableClick"></asp:Label>
    </form>
</body>
</html>
