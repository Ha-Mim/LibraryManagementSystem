<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="borrowBook.aspx.cs" Inherits="LibraryManagementSystem.UI.borrowBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Member No"></asp:Label>
        <asp:TextBox ID="enterMemberNoTextBox" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label2" runat="server" Text="Select a book"></asp:Label>
        <asp:DropDownList ID="selectBookDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="selectBookDropDownList_SelectedIndexChanged"></asp:DropDownList> <br/>
        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox><br/>  
        <asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label>
        <asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox><br/>
        <asp:Button ID="borrowButton" runat="server" Text="Borrow" OnClick="borrowButton_Click" />
        <asp:Label ID="msgLabel" runat="server" ></asp:Label>
     </div>
    </form>
</body>
</html>
