using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using Newtonsoft.Json.Linq;

namespace MarvelWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string publicKey = MarvelApiConfig.PublicKey;
            string hash = MarvelApiConfig.Hash;
            long ts = MarvelApiConfig.TimeStamp;
            string baseUrl = MarvelApiConfig.BaseUrl;
            string url = $"{baseUrl}characters?ts={ts}&apikey={publicKey}&hash={hash}";

            string result = new NetworkManager().GetJson(url);
            IEnumerable<Character> characters = null;
            JObject jsonCharacters = JObject.Parse(result);
            IList<JToken> results = jsonCharacters["data"]["result"].Children().ToList();

            foreach (var data in results)
            {
                Console.WriteLine(data["name"]);
            }

        }
    }
}
