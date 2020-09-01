using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsCatalog
{
    public partial class Form1 : Form
    {
        DataManager dm = new DataManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void TestFill()
        {
            dm.Categories.Add(new Category() { Name = "All Categories" });
            dm.Categories.Add(new Category() { Name = "Category-1" });
            dm.Categories.Add(new Category() { Name = "Category-2" });
            dm.SaveChanges();
            
            dm.Vendors.Add(new Vendor() { Name = "All Vendors" });
            dm.Vendors.Add(new Vendor() { Name = "Vendor-1" });
            dm.Vendors.Add(new Vendor() { Name = "vendor-2" });
            dm.SaveChanges();
            
            dm.Products.Add(new Product() { Name = "Product-1", CategoryId = 2, VendorId = 2, Price = 1000, Amount = 100 });
            dm.Products.Add(new Product() { Name = "Product-2", CategoryId = 2, VendorId = 1, Price = 100, Amount = 200 });
            dm.Products.Add(new Product() { Name = "Product-3", CategoryId = 1, VendorId = 2, Price = 250, Amount = 150 });
            dm.Products.Add(new Product() { Name = "Product-4", CategoryId = 1, VendorId = 1, Price = 750, Amount = 30 });
            dm.SaveChanges();
            MessageBox.Show("OK");
        }

        private void LoadProducts(List<Product> products)
        {
            listView1.Items.Clear();
            foreach (var p in products)
            {
                var item = listView1.Items.Add(p.Id.ToString());
                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.Category.ToString());
                item.SubItems.Add(p.Vendor.ToString());
                item.SubItems.Add(p.Price.ToString("F"));
                item.SubItems.Add(p.Amount.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = comboBox1.SelectedItem as Category;
            var products1 = dm.Products.Where(p => p.CategoryId == category.Id).ToList();

            var vendor = comboBox2.SelectedItem as Vendor;
            var products2 = products1.Where(p => p.VendorId == vendor.Id).ToList();

            var price = numericUpDown1.Value;
            var products3 = products2.Where(p => p.Price <= price).ToList();
            LoadProducts(products3);
        }

        private void LoadCategories()
        {
            var categories = dm.Categories.ToList();
            comboBox1.Items.Clear();
            foreach (var c in categories)
            {
                comboBox1.Items.Add(c);
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
            comboBox1.SelectedIndex = 0;
        }

        private void LoadVenders()
        {
            var venders = dm.Vendors.ToList();
            comboBox2.Items.Clear();
            foreach (var v in venders)
            {
                comboBox2.Items.Add(v);
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }
            comboBox2.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TestFill();
            LoadCategories();
            LoadVenders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            if(ac.ShowDialog() == DialogResult.OK)
            {
                string categoryName = ac.CategoryName;
                dm.Categories.Add(new Category { Name = categoryName });
                dm.SaveChanges();
                MessageBox.Show("катугория добавлена успешно");
                LoadCategories();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelCategory dc = new DelCategory();
            if(dc.ShowDialog() == DialogResult.OK)
            {
                string categoryName = dc.CategoryName;
                var target = dm.Categories.Where(c => c.Name == categoryName).LastOrDefault();
                var products = dm.Products.Where(p => p.CategoryId == target.Id).ToList();
                if(products.Count > 0)
                {
                    dm.Categories.Remove(target);
                    foreach (var p in products)
                    {
                        dm.Products.Remove(p);
                    }
                }
                else
                {
                    dm.Categories.Remove(target);
                }
                dm.SaveChanges();
                MessageBox.Show("Категория успешно удалена");
                LoadCategories();
            }
        }


    }
}
