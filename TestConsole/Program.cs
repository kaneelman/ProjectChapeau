using System;
using ChapeauModel;
using ChapeauLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start2();
        }

        void Start()
        {
            MenuCategoryService menuCategoryService = new MenuCategoryService();

            List<MenuCategory> someList = menuCategoryService.GetDinnerCategories();

            foreach (MenuCategory menuCategory in someList)
            {
                Console.WriteLine($"{menuCategory.Id} -- {menuCategory.Name} -- {menuCategory.VAT:0.0}%");
            }

            Console.WriteLine();          


            Console.ReadKey();

        }
        //to check for payment data...
        void Start2()
        {
            OrderService orderService = new OrderService();
           // MenuItemService menuItemDB = new MenuItemService();

            Order order = orderService.GetCompleteActiveOrderByTable(new DiningTable(1, TableStatus.Occupied));

            foreach (OrderMenuItem m in order.content)
            {
                Console.WriteLine($"{m.GetMenuItem().Name}");
            }

            Console.ReadKey();

        }
    }
}
