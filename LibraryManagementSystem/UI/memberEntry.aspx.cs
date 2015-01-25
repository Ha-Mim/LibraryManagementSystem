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
    public partial class memberEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Member aMember = new Member();
            aMember.Number = Convert.ToInt32(numberTextBox.Text);
            MemberManager aMemberManager= new MemberManager();
            string msg= aMemberManager.Save(aMember);
            msgLabel.Text = msg;
        }
    }
}