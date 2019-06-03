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
        //Create MenuCategoryDAO object, to get MenuCategory information
        MenuCategoryDAO menuCategoryDB = new MenuCategoryDAO();

        //Get all MenuItems from the database
        public List<MenuItem> GetAllMenuItemsDB()
        {
            string query = "SELECT id, name, price, stock, category FROM MENU_ITEM";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get a MenuItem from database by id
        public MenuItem GetMenuItemByIdDB(int id)
        {
            string query = "SELECT id, name, price, stock, category FROM MENU_ITEM WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Get MenuItems from database by category
        public List<MenuItem> GetMenuItemsByCategory(MenuCategory category)
        {
            string query = "SELECT id, name, price, stock, category FROM MENU_ITEM WHERE category = @category";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@category", category.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Change stock of MenuItem in the database
        public void ChangeStockDB(MenuItem menuItem)
        {
            //Somecode
        }

        //Convert MenuItem information to MenuItem Objects
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem((int)dr["id"], (string)dr["name"], (decimal)dr["price"], (int)dr["stock"], menuCategoryDB.GetMenuCategoryByIdDB((string)dr["category"]));
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}
