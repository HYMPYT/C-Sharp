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
    public partial class FilmControl : UserControl
    {
        public FilmControl(Film film)
        {
            InitializeComponent();
            TitleL.Text = "Title: " + film.Title;
            EpisodeL.Text = "Episode: " + film.EpisodeId.ToString();
            ReleaseDateL.Text = "Release date: " + film.ReleaseDate.ToShortDateString();
            DirectorL.Text = "Director: " + film.Director;
        }
    }
}
