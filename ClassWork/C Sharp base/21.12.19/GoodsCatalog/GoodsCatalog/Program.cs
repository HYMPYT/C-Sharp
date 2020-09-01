using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManager dm = new DataManager();
            dm.GetCategoriesList();

            Console.Write("\n> Введите название категории -> ");
            string category = Console.ReadLine();
            if (category != "")
                dm.AddCategory(category);

            Console.Write("\n> Введите название категории которую хотите удалить -> ");
            category = Console.ReadLine();
            if (category != "")
                dm.DelCategory(category);

            Console.Write("\n> Введите категорию для выборки товаров -> ");
            category = Console.ReadLine();
            if (category != "")
                dm.SelectGoodsByCategory(category);

            Console.WriteLine();
        }
    }
}
