<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="returnBook.aspx.cs" Inherits="LibraryManagementSystem.UI.returnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="EnterMemberNo" runat="server" Text="Enter Member No"></asp:Label>
        <asp:TextBox ID="memberNoTextBox" runat="server"></asp:TextBox><br/>
        <asp:Button ID="showBorrowedBooksButton" runat="server" Text="Show Borrowed Books" OnClick="showBorrowedBooksButton_Click" /><br/>
        <asp:Label ID="Label2" runat="server" Text="BorrowedBookList"></asp:Label>
        <asp:DropDownList ID="borrowedBokkListDropDownList" runat="server"></asp:DropDownList>
        <br/>
        <asp:Button ID="returnButton" runat="server" Text="Return" OnClick="returnButton_Click" />
         <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
