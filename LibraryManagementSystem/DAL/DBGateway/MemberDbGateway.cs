using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class MemberDbGateway :DBGateway
    {
        public MemberDbGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }
        public Member UniqueCheker(int number)
        {
            string query = "SELECT *FROM T_Member WHERE Number ='" + number + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Read();
               Member aMember = new Member();

                aMember.Id = Convert.ToInt32(aSqlDataReader["Id"]);
                aMember.Number = Convert.ToInt32(aSqlDataReader["Number"]);

                aSqlDataReader.Close();
                aSqlConnection.Close();

                return aMember;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }

        public Member HasId(int memberId)
        {

            string query = "SELECT *FROM T_Member WHERE Id ='" + memberId + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Read();
                Member aMember = new Member();

                aMember.Id = Convert.ToInt32(aSqlDataReader["Id"]);

                aSqlDataReader.Close();
                aSqlConnection.Close();

                return aMember;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }

        public void Save(Member aMember)
        {
            string query = "INSERT INTO T_Member VALUES(" + aMember.Number + ")";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }
    }
}