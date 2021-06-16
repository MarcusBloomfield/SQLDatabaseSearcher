using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Query
{
    public partial class AddUserDialog : Form
    {
        AddUserController addUserController = new AddUserController();
        public AddUserDialog()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            addUserController.AddUser(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text, this);
        }
    }
}
