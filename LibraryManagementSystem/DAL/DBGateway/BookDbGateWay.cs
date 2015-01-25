using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class BookDbGateWay : DBGateway
    {
          public BookDbGateWay()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }
        
        public List<Book> GetAll()
        {
            string query = "SELECT *FROM T_Book";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            List<Book> books = new List<Book>();

            while (aSqlDataReader.Read())
            {

               Book aBook = new Book();
                aBook.Id = (int)aSqlDataReader["id"];
                aBook.Title = aSqlDataReader["title"].ToString();
                aBook.Author = aSqlDataReader["author"].ToString();
                aBook.Publisher = aSqlDataReader["publisher"].ToString();
                books.Add(aBook);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return books;
        }
        public Book Find(int id)
        {
            foreach (Book aBook in GetAll())
            {
                if (aBook.Id == id)
                {
                    return aBook;
                }
            }
            return null;
        }


        public void Save(Book aBook)
        {
            string query = "INSERT INTO T_Book VALUES('" + aBook.Title + "','"+aBook.Author+"','"+aBook.Publisher+"')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }
        public Book UniqueChecker(string title)
        {

            string query = "SELECT *FROM T_Book WHERE title ='" + title + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Read();
                Book aBook = new Book();

                aBook.Title = (aSqlDataReader["title"]).ToString();

                aSqlDataReader.Close();
                aSqlConnection.Close();

                return aBook;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }
    }

}