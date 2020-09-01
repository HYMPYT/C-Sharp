using SWAPI_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWAPI_APP
{
    public partial class Form1 : Form
    {
        SWManager swManager;
        public Form1()
        {
            InitializeComponent();
            swManager = new SWManager();
            numericOffset.Maximum = int.MaxValue;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadBtn.Enabled = false;
            ClearCharacters();
            Task.Factory.StartNew(() => LoadCharacters((int)numericOffset.Value, (int)numericLimit.Value));
        }

        private void LoadCharacters(int offset, int limit)
        {
            var characters = swManager.GetCharacters(offset, offset + limit);
            Parallel.ForEach(characters, (character) =>
            {
                CharacterControl cf = new CharacterControl(character);
                flpCharacter.Invoke((MethodInvoker)delegate { flpCharacter.Controls.Add(cf); });
            });
            LoadBtn.Invoke((MethodInvoker)delegate { LoadBtn.Enabled = true; });
        }

        private void ClearCharacters()
        {
            if (flpCharacter.Controls.Count > 0)
                flpCharacter.Controls.Clear();
        }
    }
}
