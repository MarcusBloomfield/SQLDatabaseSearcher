using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataBase_Query
{
    public class DataBaseAccess
    {
        public List<User> GetUsersByLastName(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SeverConnectionManager.DataBaseConnectionString("sample")))
            {
                var users = connection.Query<User>("dbo.SearchForUser @Search", new {Search = lastName}).ToList();
                return users;
            }
        }
        public void AddUser(string firstName, string lastName, string email, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SeverConnectionManager.DataBaseConnectionString("sample")))
            {
                List<User> users = new List<User>();
                users.Add(new User { FirstName = firstName, LastName = lastName, Email = email, Password = password });
                connection.Execute("dbo.AddNewUser @FirstName, @LastName, @Email, @Password", users);
            }
        }
    }
}
