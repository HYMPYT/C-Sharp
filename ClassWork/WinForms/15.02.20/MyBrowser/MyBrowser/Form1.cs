using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        DataManager dm = new DataManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void GoToSite()
        {
            string address = textBox1.Text;
            if (address == "")
            {
                MessageBox.Show("Предупреждение", "Не указан адрес страницы", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (address.IndexOf(".") == -1)
                {
                    address = $"http://bing.com/search?q={address}";
                }
                else if (address.IndexOf("http") == -1)
                {
                    address = $"https://{address}";
                }
                webBrowser1.Navigate(address);
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            GoToSite();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoToSite();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://bing.com");
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void backwardBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void testCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dm.Categories.Add(new Category() { Name = "Учебные сайты" });
            //dm.Categories.Add(new Category() { Name = "Игровые порталы" });
            //dm.Categories.Add(new Category() { Name = "Новостные порталы" });
            //dm.SaveChanges();
            //MessageBox.Show("OK");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCategories();
            UpdateSites();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            if (ac.ShowDialog() == DialogResult.OK)
            {
                string name = ac.CategoryName;
                dm.Categories.Add(new Category() { Name = name });
                dm.SaveChanges();
                MessageBox.Show("Категория сохранена");
                UpdateCategories();
            }
        }

        private void UpdateCategories()
        {
            comboBox1.Items.Clear();
            foreach (var x in dm.Categories)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void delCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string categoryName = comboBox1.SelectedItem.ToString();
            DelCategory dc = new DelCategory();
            dc.CategoryName = categoryName;
            if (dc.ShowDialog() == DialogResult.OK)
            {
                var target = dm.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
                dm.Categories.Remove(target);
                dm.SaveChanges();
                MessageBox.Show($"Категория {categoryName} - успешно удалена", "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCategories();
            }
        }

        private void UpdateSites()
        {
            listBox1.Items.Clear();
            foreach(var x in dm.Sites)
            {
                listBox1.Items.Add(x.Name);
            }
        }

        private void addSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSite addSite = new AddSite();
            addSite.SiteURL = webBrowser1.Url.ToString();
            if(addSite.ShowDialog() == DialogResult.OK)
            {
                var select = dm.Categories.Where(c => c.Name == addSite.CategoryNameForSite).FirstOrDefault();
                int category_id = select.Id;
                dm.Sites.Add(new Site() { Name = addSite.SiteName, Url = addSite.SiteURL, CategoryId = category_id });
                dm.SaveChanges();
                MessageBox.Show("Сайт добавлен");
                UpdateSites();
            }
        }

        private void delSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string siteName = listBox1.SelectedItem.ToString();
            DelSite ds = new DelSite();
            ds.SiteName = siteName;
            if(ds.ShowDialog() == DialogResult.OK)
            {
                var target = dm.Sites.Where(c => c.Name == siteName).FirstOrDefault();
                dm.Sites.Remove(target);
                dm.SaveChanges();
                MessageBox.Show($"Сайт {siteName} успешно удален", "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSites();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string siteName = listBox1.SelectedItem.ToString();
            var tmp = dm.Sites.Where(c => c.Name == siteName).FirstOrDefault();
            string SiteUrl = tmp.Url;
            webBrowser1.Navigate(SiteUrl);
        }
    }
}
