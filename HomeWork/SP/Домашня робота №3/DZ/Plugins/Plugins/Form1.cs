using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugins
{
    public partial class Form1 : Form, Interface.IMainApp
    {
        private async Task<bool> PlaginRunAsync(string plaginName) => await Task.Factory.StartNew(() => PluginRun(plaginName, this));
        private readonly object _locker = new object();
        Hashtable plugins = new Hashtable();
        public Form1()
        {
            InitializeComponent();

            FindPlugins();
            CreatePluginsMenu();
        }


        public Bitmap Image
        {
            get { return (Bitmap)pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Блабла", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void CreatePluginsMenu()
        {

            EventHandler handler = new EventHandler(OnPluginClick);

            foreach (string name in plugins.Keys)
            {

                menuItemPlugins.DropDownItems.Add(name, null, handler);

            }
        }


        private async void OnPluginClick(object sender, EventArgs args)
        {
            var res = await PlaginRunAsync(((ToolStripMenuItem)sender).Text);
            if (res)
                pictureBox1.Invalidate();
            else
                MessageBox.Show($"Plugin \"{((ToolStripMenuItem)sender).Text}\" isn't available at this very moment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Графические файлы (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
                try
                {
                    Bitmap bmp = new Bitmap(dlg.FileName);
                    pictureBox1.Image = bmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
        }


        void FindPlugins()
        {

            string folder = System.AppDomain.CurrentDomain.BaseDirectory;


            string[] files = Directory.GetFiles(folder, "*.dll");

            foreach (string file in files)
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);

                    foreach (Type type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("Interface.IPlugin");

                        if (iface != null)
                        {
                            Interface.IPlugin plugin = (Interface.IPlugin)Activator.CreateInstance(type);
                            plugins.Add(plugin.Name, plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                ofd.Filter = "JPeg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif";
                ofd.Title = "Save an Image File";
                ofd.FileName = "newImage";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (pictureBox1.Image != null)
                {
                    if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    {
                        try
                        {
                            FileStream fs = ofd.OpenFile() as FileStream;

                            ImageFormat frmt = ImageFormat.Png;
                            switch (ofd.FilterIndex)
                            {
                                case 1:
                                    frmt = ImageFormat.Jpeg;
                                    break;
                                case 2:
                                    frmt = ImageFormat.Png;
                                    break;
                                case 3:
                                    frmt = ImageFormat.Bmp;
                                    break;
                                case 4:
                                    frmt = ImageFormat.Gif;
                                    break;
                                default:
                                    break;
                            }

                            pictureBox1.Image.Save(fs, frmt);
                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Exception on image saving.");
                        }
                    }
                }
                else
                    MessageBox.Show("There is no Image to save", "Error!");
            }
        }

        public bool PluginRun(string pluginName, Interface.IMainApp runOn)
        {
            try
            {
                Interface.IPlugin plugin = (Interface.IPlugin)plugins[pluginName];
                lock (_locker)
                {
                    plugin.Transform(runOn);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Plugin {pluginName} isn't awailable at this very moment.\n {ex.Message}");
                return false;
            }
        }
    }
}
