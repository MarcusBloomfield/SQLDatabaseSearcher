using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Query
{
    class SearchController
    {
        DataBaseAccess dataBaseAcces = new DataBaseAccess();
        List<User> users = new List<User>();

        public void OnSearch(string searchData, ListBox listBox)
        {
            users = dataBaseAcces.GetUsersByLastName(searchData);
            listBox.DataSource = users;
            listBox.DisplayMember = "GetAllUserData";
        }

        public SearchController(ListBox listBox)
        {
            listBox.DataSource = users;
            listBox.DisplayMember = "GetAllUserData";
        }
    }
}
