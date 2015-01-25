using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI
{
    public partial class bookEntry : System.Web.UI.Page
    {
        BookManager aBookManager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Book aBook = new Book();
            aBook.Title = titleTextBox.Text;
            aBook.Author = authorTextBox.Text;
            aBook.Publisher = publisherTextBox.Text;
            string msg=aBookManager.Save(aBook);
            msgLabel.Text = msg;
        }
    }
}