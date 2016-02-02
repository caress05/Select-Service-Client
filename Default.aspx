<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownListShowArtists" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListShowArtists_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridViewShowArtists" runat="server"></asp:GridView>
        <asp:DropDownList ID="DropDownListShowVenues" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListShowVenues_SelectedIndexChanged1"></asp:DropDownList>
        <asp:GridView ID="GridViewShowVenues" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
