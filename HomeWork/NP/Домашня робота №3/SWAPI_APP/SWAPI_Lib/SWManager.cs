using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI_Lib
{
    public class SWManager
    {
        private readonly string BaseUrl = "https://swapi.dev/api/";
        private NetworkManager networkManager;
        public SWManager()
        {
            networkManager = new NetworkManager();
        }

        public IEnumerable<Character> GetCharacters(int startId, int endId)
        {
            List<string> urls = new List<string>();
            for (int i = startId; i < endId; i++)
                urls.Add($"{BaseUrl}people/{i}/");

            List<Character> characters = new List<Character>();
            Parallel.ForEach(urls, (data) =>
            {
                characters.Add(GetCharacter(data));
            });
            return characters;
        }

        public Character GetCharacter(string url)
        {
            string result = networkManager.GetJson(url);

            JObject jsonCharacter = JObject.Parse(result);
            JToken data = jsonCharacter.SelectToken("");

            Character character = new Character
            {
                Name = $"{data["name"]}",
                BirthYear = $"{data["birth_year"]}",
                EyeColor = $"{data["eye_color"]}",
                Gender = $"{data["gender"]}",
                HairColor = $"{data["hair_color"]}",
                Height = $"{data["height"]}",
                Mass = $"{data["mass"]}",
                SkinColor = $"{data["skin_color"]}",
                HomeWorld = GetPlanet($"{data["homeworld"]}"),
                Films = GetFilms(data["films"].Children().ToList().Select(i => i.ToString()).ToArray()).ToList(),
                Starships = GetStarships(data["starships"].Children().ToList().Select(i => i.ToString()).ToArray()).ToList(),
                Species = GetSpecies(data["species"].Children().ToList().Select(i => i.ToString()).ToArray()).ToList()
            };
            return character;
        }

        public IEnumerable<Film> GetFilms(params string[] url)
        {
            List<Film> films = new List<Film>();

            Parallel.ForEach(url, (data) =>
            {
                films.Add(GetFilm(data));
            });

            return films;
        }

        public Film GetFilm(string url)
        {
            string result = networkManager.GetJson(url);

            JObject jsonFilms = JObject.Parse(result);
            JToken data = jsonFilms.SelectToken("");

            Film fm = new Film
            {
                Title = $"{data["title"]}",
                EpisodeId = (int)data["episode_id"],
                Director = $"{data["director"]}",
                ReleaseDate = (DateTime)data["release_date"]
            };

            return fm;
        }

        public IEnumerable<Starship> GetStarships(params string[] url)
        {
            List<Starship> starships = new List<Starship>();

            Parallel.ForEach(url, (data) =>
            {
                starships.Add(GetStarship(data));
            });

            return starships;
        }

        public Starship GetStarship(string url)
        {
            string result = networkManager.GetJson(url);

            JObject jsonStarship = JObject.Parse(result);
            JToken data = jsonStarship.SelectToken("");

            Starship starship = new Starship
            {
                Name = $"{data["name"]}",
                Model = $"{data["model"]}",
                StarshipClass = $"{data["starship_class"]}",
                Manufacturer = $"{data["manufacturer"]}",
                MaxAtmospheringSpeed = $"{data["max_atmosphering_speed"]}",
                HyperDriveRating = $"{data["hyperdrive_rating"]}"
            };

            return starship;
        }

        public Planet GetPlanet(string url)
        {
            string result = networkManager.GetJson(url);

            JObject jsonPlanet = JObject.Parse(result);
            JToken data = jsonPlanet.SelectToken("");

            Planet planet = new Planet
            {
                Name = $"{data["name"]}",
                Diameter = $"{data["diameter"]}",
                Climate = $"{data["climate"]}",
                Population = $"{data["population"]}",
                Terrain = $"{data["terrain"]}"
            };

            return planet;
        }

        public IEnumerable<Specie> GetSpecies(params string[] url)
        {
            List<Specie> species = new List<Specie>();

            Parallel.ForEach(url, (data) =>
            {
                species.Add(GetSpecie(data));
            });

            return species;
        }

        public Specie GetSpecie(string url)
        {
            string result = networkManager.GetJson(url);

            JObject jsonSpecie = JObject.Parse(result);
            JToken data = jsonSpecie.SelectToken("");

            Specie specie = new Specie
            {
                Name = $"{data["name"]}",
                Classification = $"{data["classification"]}",
                Designation = $"{data["designation"]}",
                AverageLifespan = $"{data["average_lifespan"]}",
                Language = $"{data["language"]}"
            };

            return specie;
        }
    }
}
