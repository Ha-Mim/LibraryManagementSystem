using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LibraryManagementSystem.DAL.DBGateway
{
    public class DBGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["connectionStringForBookDB"].ConnectionString;
        public SqlConnection aSqlConnection;
        public SqlCommand aSqlCommand;
    }
}