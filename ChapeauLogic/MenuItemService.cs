using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;


namespace ChapeauLogic
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDB = new MenuItemDAO();

        public List<MenuItem> GetAllMenuItems()
        {
            return menuItemDB.GetAllMenuItemsDB();
        }

        public MenuItem GetMenuItemById(int id)
        {
            return menuItemDB.GetMenuItemByIdDB(id);
        }

        public List<MenuItem> GetMenuItemsByCategory (MenuCategory category)
        {
            return menuItemDB.GetMenuItemsByCategory(category);
        }

    }
}
