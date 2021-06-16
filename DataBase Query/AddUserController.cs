using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Query
{
    class AddUserController
    {
        DataBaseAccess dataBaseAccess = new DataBaseAccess();
        public void AddUser(string firstName, string lastName, string email, string password, AddUserDialog addUserDialog)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(firstName))
            {
                dataBaseAccess.AddUser(firstName, lastName, email, password);
                addUserDialog.Close();
            }
            else
            {
                MessageBox.Show("First name, last name, email and password cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
