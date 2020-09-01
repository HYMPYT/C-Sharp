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
    public partial class StarshipControl : UserControl
    {
        public StarshipControl(Starship starship)
        {
            InitializeComponent();
            NameL.Text = "Name: " + starship.Name;
            ModelL.Text = "Model: " + starship.Model;
            StarshipClassL.Text = "Class: " + starship.StarshipClass;
            ManufacturerL.Text = "Manufacturer: " + starship.Manufacturer;
            HyperDriveRatingL.Text = "Hyper drive rating: " + starship.HyperDriveRating;
            MaxAtmospheringSpeedL.Text = "Max speed: " + starship.MaxAtmospheringSpeed;
        }
    }
}
