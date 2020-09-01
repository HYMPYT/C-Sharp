using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI_Lib
{
    public class Character
    {
        public string Name { get; set; }
        public string BirthYear { get; set; }
        public string EyeColor { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string SkinColor { get; set; }
        public Planet HomeWorld { get; set; }
        public List<Film> Films { get; set; }
        public List<Specie> Species { get; set; }
        public List<Starship> Starships { get; set; }
    }
}
