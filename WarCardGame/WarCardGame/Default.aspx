<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WarCardGame.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="okButton" runat="server" Text="Button" OnClick="OkButton_Click" />
            <br />
            <br />
            <asp:Label ID="dealLabel" runat="server" Text=""></asp:Label>
            <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
