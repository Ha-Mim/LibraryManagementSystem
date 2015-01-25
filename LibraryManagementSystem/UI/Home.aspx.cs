using System;

namespace LibraryManagementSystem.UI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void borrowBookButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("borrowBook.aspx");
        }

        protected void returnBookButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("returnBook.aspx");

        }

        protected void memberEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("memberEntry.aspx");
        }

        protected void bookEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("bookEntry.aspx");
        }
    }
}