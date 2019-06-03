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

        public List<MenuCategory> GetAllMenuCategories()
        {
            return menuCategoryDB.GetAllMenuCategoriesDB();
        }

        public MenuCategory GetMenuCategoryById(string id)
        {
            return menuCategoryDB.GetMenuCategoryByIdDB(id);
        }

        public List<MenuCategory> GetDrinkCategories()
        {
            return menuCategoryDB.GetDrinkCategoriesDB();
        }

        public List<MenuCategory> GetLunchCategories()
        {
            return menuCategoryDB.GetLunchCategoriesDB();
        }

        public List<MenuCategory> GetDinnerCategories()
        {
            return menuCategoryDB.GetDinnerCategoriesDB();
        }


    }
}
