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
    public partial class MainDialog : Form
    {
        SearchController searchController;
        public MainDialog()
        {
            InitializeComponent();
            searchController = new SearchController(UserListBox);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchController.OnSearch(SearchTextBox.Text, UserListBox);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUserDialog addUserDialog = new AddUserDialog();
            addUserDialog.Show();
        }
    }
}
