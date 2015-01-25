using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.DBGateway;

namespace LibraryManagementSystem.BLL
{
    public class LibraryManager
    {
        LibraryDbGateway aLibraryDbGateway = new LibraryDbGateway();
        BookDbGateWay aBookDbGateWay = new BookDbGateWay();
        public void BorrowBook(Library aLibary)
        { 
          MemberDbGateway aMemberDbGateway = new MemberDbGateway();
          aLibraryDbGateway.Save(aLibary);
        }

        public List<Book> GetSelectedBook(int memberId)
        {
           return aLibraryDbGateway.GetSelectedBook(memberId);
           
        }

        public string Update(Library aLibrary)
        {
             aLibraryDbGateway.Update(aLibrary);
            return "updated";
        }
    }
}