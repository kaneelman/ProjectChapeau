using System;
using ChapeauModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class MenuCategoryDAO : Base
    {
        public List<MenuCategory> GetAllMenuCategoriesDB()
        {
            string query = "SELECT id, name, vat FROM MENU_CATEGORY";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public MenuCategory GetMenuCategoryByIdDB(string id)
        {
            string query = "SELECT id, name, vat FROM MENU_CATEGORY WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<MenuCategory> ReadTables (DataTable dataTable)
        {
            List<MenuCategory> menuCategories = new List<MenuCategory>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuCategory menuCategory = new MenuCategory((string)dr["id"], (string)dr["name"], (int)dr["vat"]);
                menuCategories.Add(menuCategory);
            }
            return menuCategories; 
        }
    }
}
