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
    public partial class CharacterControl : UserControl
    {
        public CharacterControl(Character character)
        {
            InitializeComponent();
            NameL.Text = "Name: " + character.Name;
            BirthYearL.Text = "Birth year: " + character.BirthYear;
            GenderL.Text = "Gender: " + character.Gender;
            HeightL.Text = "Height: " + character.Height;
            MassL.Text = "Mass: " + character.Mass;
            HairColorL.Text = "Hair color: " + character.HairColor;
            EyeColorL.Text = "Eye color: " + character.EyeColor;
            SkinColorL.Text = "Skin color: " + character.SkinColor;

            HomeNameL.Text = "Name: " + character.HomeWorld.Name;
            HomeDiameterL.Text = "Diameter: " + character.HomeWorld.Diameter;
            HomePopulationL.Text = "Population: " + character.HomeWorld.Population;
            HomeClimateL.Text = "Climate: " + character.HomeWorld.Climate;
            HomeTerrainL.Text = "Terrain: " + character.HomeWorld.Terrain;

            foreach (var specie in character.Species)
            {
                flpSpecies.Controls.Add(new SpeciesControl(specie));
            }

            foreach (var starship in character.Starships)
            {
                flpStarships.Controls.Add(new StarshipControl(starship));
            }

            foreach (var film in character.Films)
            {
                flpFilms.Controls.Add(new FilmControl(film));
            }
        }
    }
}
