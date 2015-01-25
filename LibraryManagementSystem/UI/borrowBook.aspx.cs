using System;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI
{
    public partial class borrowBook : System.Web.UI.Page
    {

        BookManager aBookManager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    selectBookDropDownList.DataSource = aBookManager.GetAll();
                   
                    selectBookDropDownList.DataTextField = "Title";
                    selectBookDropDownList.DataValueField = "Id";
                    selectBookDropDownList.DataBind();
            }

        }

        private string msg = "";
        protected void borrowButton_Click(object sender, EventArgs e)
        {
            MemberManager aMemberManager = new MemberManager();
            Library aLibrary = new Library();
            Member aMember = aMemberManager.Search(Convert.ToInt32(enterMemberNoTextBox.Text));
            if (aMember != null)
            {
                aLibrary.MemberId = aMember.Id;
                aLibrary.BookId = Convert.ToInt32(selectBookDropDownList.SelectedValue);
                aLibrary.BorrowStatus = true;
                LibraryManager aLibraryManager = new LibraryManager();
                aLibraryManager.BorrowBook(aLibrary);
                msg = "This book is borrowed by member whose id is : " + aMember.Number;
            }
            else
            {
                msg = "Not Exists";
            }
           
            msgLabel.Text = msg;
        }

        protected void selectBookDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(selectBookDropDownList.SelectedValue);
            Book aBook = aBookManager.Find(id);
            authorTextBox.Text = aBook.Author;
            publisherTextBox.Text = aBook.Publisher;
        }
    }
}