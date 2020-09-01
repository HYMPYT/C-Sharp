using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoodsCatalog
{
    class DataManager
    {
        string path1, path2;
        XDocument doc1, doc2;
        public DataManager()
        {
            path1 = @"..\..\Data\Categories.xml";
            path2 = @"..\..\Data\Goods.xml";
            doc1 = XDocument.Load(path1);
            doc2 = XDocument.Load(path2);
        }
        public void GetCategoriesList()
        {
            var res = doc1.Element("categories").Elements("category").ToList();
            foreach (var c in res)
            {
                Console.WriteLine($"{c.Attribute("id").Value}. {c.Attribute("name").Value}");
            }
        }
        public void AddCategory(string category_name)
        {
            var last_category = doc1.Element("categories").Elements("category")
                .LastOrDefault();
            int n = int.Parse(last_category.Attribute("id").Value);

            XElement elem = new XElement("category",
                new XAttribute("id", (n + 1).ToString()),
                new XAttribute("name", category_name));

            doc1.Element("categories").Add(elem);
            doc1.Save(path1);

            Console.WriteLine("Категория успешно добавлена");
        }
        public void DelCategory(string category_name)
        {
            var categoryX = doc1.Element("categories").Elements("category")
                .Where(c => c.Attribute("name").Value == category_name)
                .FirstOrDefault();

            if (categoryX == null)
            {
                Console.WriteLine("Категория не существует!");
            }
            else
            {
                categoryX.Remove();
                doc1.Save(path1);
                Console.WriteLine("Категория успешно удалена");
            }
        }
        public void SelectGoodsByCategory(string category_name)
        {
            var categoryX = doc1.Element("categories").Elements("category")
                .Where(x => x.Attribute("name").Value == category_name)
                .FirstOrDefault();

            if (categoryX != null)
            {
                string cid = categoryX.Attribute("id").Value;

                var goods = doc2.Element("goods").Elements("product")
                    .Where(p => p.Attribute("cid").Value == cid)
                    .ToList();

                if (goods.Count == 0)
                {
                    Console.WriteLine("Товары такой категории не найдены");
                }
                else
                {
                    foreach (var p in goods)
                    {
                        Console.WriteLine("{0, 5}{1, 30}{2, 15}{3, 10}",
                            p.Attribute("id").Value,
                            p.Attribute("name").Value,
                            p.Attribute("producer").Value,
                            p.Attribute("price").Value);
                    }
                }
            }
        }
    }
}
