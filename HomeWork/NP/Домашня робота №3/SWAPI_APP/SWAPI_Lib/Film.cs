using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI_Lib
{
    public class Film
    {
        public string Title { get; set; }
        public int EpisodeId { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
