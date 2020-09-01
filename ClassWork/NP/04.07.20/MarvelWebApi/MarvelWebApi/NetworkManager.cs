using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MarvelWebApi
{
    class NetworkManager
    {
        public string GetJson(string Url) => new WebClient().DownloadString(Url);
    }
}
