using MyBestMarvelLib;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMarvel.Utils;

namespace WinFormMarvel
{
    public partial class Form1 : Form
    {
        MarvelManager marvelManager;
        public Form1()
        {
            InitializeComponent();
            marvelManager = new MarvelManager();
            numericOffset.Maximum = int.MaxValue;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadBtn.Enabled = false;
            ClearCharacters();
            Task.Factory.StartNew(() => LoadCharacters((int)numericOffset.Value, (int)numericLimit.Value));
        }

        private void LoadCharacters(int offset, int limit)
        {
            var characters = marvelManager.GetCharacters(offset, limit);
            Parallel.ForEach(characters, (character) =>
            {
                Label lblName = new Label
                {
                    Text = character.Name,
                    Width = 200
                };

                PictureBox pbThumbnail = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 200,
                    Height = 200,
                    Image = ImageUtil.ImageFromUrl(character.Thumbnail)
                };
                Panel pnlCard = new Panel
                {
                    Width = 300,
                    Height = 300
                };
                pnlCard.Controls.Add(lblName);
                pnlCard.Controls.Add(pbThumbnail);
                flpCharacters.Invoke((MethodInvoker)delegate { flpCharacters.Controls.Add(pnlCard); });
            });
            loadBtn.Invoke((MethodInvoker)delegate { loadBtn.Enabled = true; });
        }

        private void ClearCharacters()
        {
            if (flpCharacters.Controls.Count > 0)
                flpCharacters.Controls.Clear();
        }
    }
}
