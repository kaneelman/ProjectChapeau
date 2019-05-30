using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class MenuItemDAO : Base
    {
        MenuCategoryDAO menuCategoryDB = new MenuCategoryDAO();

        public List<MenuItem> GetAllMenuItemsDB()
        {
            string query = "SELECT I.id, I.name, price, stock, category, C.name, vat FROM MENU_ITEM AS I JOIN MENU_CATEGORY AS C ON I.category = C.id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public MenuItem GetMenuCategoryByIdDB(string id)
        {
            string query = "SELECT I.id, I.name, price, stock, category, C.name, vat FROM MENU_ITEM AS I JOIN MENU_CATEGORY AS C ON I.category = C.id WHERE I.id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem((int)dr["I.id"], (string)dr["I.name"], (decimal)dr["price"], (int)dr["stock"], new MenuCategory((string)dr["category"], (string)dr["C.name"], (int)dr["vat"]));
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        //public MenuItem GetMenuCategoryByIdDB(string id)
        //{
        //    string query = "SELECT I.id, I.name, price, stock, category, C.name, vat FROM MENU_ITEM WHERE I.id = @id";
        //    SqlParameter[] sqlParameters = (new[]
        //    {
        //        new SqlParameter("@id", id)
        //    });
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        //}

        //private List<MenuItem> ReadTables(DataTable dataTable)
        //{
        //    List<MenuItem> menuItems = new List<MenuItem>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        MenuItem menuItem = new MenuItem((int)dr["I.id"], (string)dr["I.name"], (decimal)dr["price"], (int)dr["stock"], menuCategoryDB.GetMenuCategoryByIdDB((string)dr["category"]));
        //        menuItems.Add(menuItem);
        //    }
        //    return menuItems;
        //}
    }
}
