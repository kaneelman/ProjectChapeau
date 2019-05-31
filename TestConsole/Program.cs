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
            myProgram.Start();
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
    }
}
