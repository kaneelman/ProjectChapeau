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
            DiningTableService diningTableService = new DiningTableService();

            List<DiningTable> someList = diningTableService.GetDiningTables();

            foreach (DiningTable table in someList)
            {
                Console.WriteLine($"{table.Id:00} -- {table.Status.ToString()}");
            }

            Console.WriteLine();
            DiningTable table5 = diningTableService.GetDiningTable(5);
            Console.WriteLine($"{table5.Id} -- {table5.Status}");




            Console.ReadKey();

        }
    }
}
