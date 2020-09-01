using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWAPI_Lib;

namespace SWAPI_APP
{
    public partial class SpeciesControl : UserControl
    {
        public SpeciesControl(Specie specie)
        {
            InitializeComponent();
            NameL.Text = "Name: " + specie.Name;
            ClassificationL.Text = "Classification: " + specie.Classification;
            DesignationL.Text = "Designation: " + specie.Designation;
            AverageLifespanL.Text = "Average lifespan: " + specie.AverageLifespan;
            LanguageL.Text = "Language: " + specie.Language;
        }
    }
}
