using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace GuideEditor
{
    public partial class Form1 : Form
    {
        string path;
        XDocument doc;
        public Form1()
        {
            InitializeComponent();
            path = @"..\..\Guide\Guide1\Content.xml";
            if (File.Exists(path))
                doc = XDocument.Load(path);
            else
                MessageBox.Show("Не найден файл содержания документа!");
        }

        private void LoadContent()
        {
            var root = doc.Element("root");
            TreeNode rootNode = new TreeNode(root.Attribute("name").Value, 0, 1);

            var chapters = root.Elements("chapter");
            foreach (var chapt in chapters)
            {
                TreeNode chaptNode = new TreeNode(chapt.Attribute("name").Value, 2, 3);

                var paragraphes = chapt.Elements("Paragraph");
                foreach (var p in paragraphes)
                {
                    TreeNode paragNode = new TreeNode(p.Attribute("name").Value, 4, 5);
                    chaptNode.Nodes.Add(paragNode);
                }
                rootNode.Nodes.Add(chaptNode);
            }

            treeView1.Nodes.Add(rootNode);
            treeView1.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeName = treeView1.SelectedNode.Text;
            string pathName = @"..\..\Guide\Guide1\" + nodeName + ".rtf";
            if(File.Exists(pathName))
            {
                richTextBox1.LoadFile(pathName);
            }
        }
    }
}
