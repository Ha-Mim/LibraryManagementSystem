using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class LibraryDbGateway : DBGateway
    {
         public LibraryDbGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }

        public void Save(Library aLibrary)
        {

            string query = "INSERT INTO T_Borrow_Book VALUES ('" + aLibrary.MemberId + "','" + aLibrary.BookId + "','" +
                           aLibrary.BorrowStatus  + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }
          public List<Book> GetSelectedBook(int memberId)
        {
            List< Book> aList = new List<Book>();
            string query = "SELECT * FROM T_Borrow_Book WHERE memberId ='" + memberId + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            BookDbGateWay aBookDbGateWay = new BookDbGateWay();
              while (aSqlDataReader.Read())
              {
                  Book aBook = new Book();
                  aBook.Id = Convert.ToInt32(aSqlDataReader["bookId"]);
                  Book newBook = aBookDbGateWay.Find(aBook.Id);
                  aList.Add(newBook);
              }
              aSqlDataReader.Close();
              aSqlConnection.Close();

                return aList;
            }

        public void Update(Library aLibrary)
        {
            string updateQuery = "UPDATE T_Borrow_Book SET borrowStatus='" + aLibrary.BorrowStatus + 
                                "' WHERE memberId= '" + aLibrary.MemberId + "' AND bookId='"+aLibrary.BookId+"';";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(updateQuery, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }
    }
}