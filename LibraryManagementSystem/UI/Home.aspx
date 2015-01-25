<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibraryManagementSystem.UI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="borrowBookButton" runat="server" Text="Borrow Book" OnClick="borrowBookButton_Click" />
        <asp:Button ID="returnBookButton" runat="server" Text="Return Book" OnClick="returnBookButton_Click" />
        <br/>
        <asp:Button ID="memberEntryButton" runat="server" Text="Member Entry" OnClick="memberEntryButton_Click" style="height: 26px" />
        <asp:Button ID="bookEntryButton" runat="server" Text="Book Entry" OnClick="bookEntryButton_Click" />
    </div>
    </form>
</body>
</html>
