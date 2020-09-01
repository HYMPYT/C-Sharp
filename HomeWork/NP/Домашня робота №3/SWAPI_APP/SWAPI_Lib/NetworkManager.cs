using System.Net;

namespace SWAPI_Lib
{
    public class NetworkManager
    {
        public string GetJson(string url) => new WebClient().DownloadString(url);
    }
}
