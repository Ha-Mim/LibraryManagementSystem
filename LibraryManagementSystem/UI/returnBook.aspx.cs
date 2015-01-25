using System;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI
{
    public partial class returnBook : System.Web.UI.Page
    {
        MemberManager aMemberManager = new MemberManager();
        LibraryManager aLibraryManager = new LibraryManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showBorrowedBooksButton_Click(object sender, EventArgs e)
        {
            Member aMember = aMemberManager.Search(Convert.ToInt32(memberNoTextBox.Text));
        
            borrowedBokkListDropDownList.DataSource=aLibraryManager.GetSelectedBook(aMember.Id);
            borrowedBokkListDropDownList.DataTextField = "Title";
            borrowedBokkListDropDownList.DataValueField = "Id";
            borrowedBokkListDropDownList.DataBind();
        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            Library aLibrary = new Library();
            aLibrary.BookId = Convert.ToInt32(borrowedBokkListDropDownList.SelectedValue);
            aLibrary.MemberId = aMemberManager.Search(Convert.ToInt32(memberNoTextBox.Text)).Id;
            aLibrary.BorrowStatus = false;
            string msg=aLibraryManager.Update(aLibrary);
            msgLabel.Text = msg;

        }
    }
}