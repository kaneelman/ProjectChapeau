using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuCategoryService
    {
        MenuCategoryDAO menuCategoryDB = new MenuCategoryDAO();

        public List<MenuCategory> GetMenuCategories()
        {
            return menuCategoryDB.GetAllMenuCategoriesDB();
        }

        public MenuCategory GetMenuCategoryById(string id)
        {
            return menuCategoryDB.GetMenuCategoryByIdDB(id);
        }
    }
}
