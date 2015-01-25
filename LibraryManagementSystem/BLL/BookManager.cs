using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.DBGateway;

namespace LibraryManagementSystem.BLL
{ 
    
    public class BookManager
    {
        BookDbGateWay aBookDbGateWay = new BookDbGateWay();
        public List<Book> GetAll()
        {
            return aBookDbGateWay.GetAll();
        }
        public Book Find(int id)
        {
           return aBookDbGateWay.Find(id);
        }

        public string Save(Book aBook)
        {
            if (aBookDbGateWay.UniqueChecker(aBook.Title) == null)
            {
                aBookDbGateWay.Save(aBook);
                return "Successfully Saved";
            }
            else
            {
                return "Already exists";
            }
        }
    }
}