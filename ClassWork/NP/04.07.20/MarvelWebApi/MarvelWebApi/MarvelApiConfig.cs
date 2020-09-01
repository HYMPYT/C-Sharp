using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MarvelWebApi
{
    static class MarvelApiConfig
    {
        public static string PublicKey { get; } = "be619aaf5db1d12b27c11a76197c7e09";
        private static string PrivateKey { get; } = "e428d3283915113c480e2608a3a2479cdcab0185";
        public static long TimeStamp => DateTimeOffset.UtcNow.Second;
        public static string Hash => Md5(TimeStamp, PrivateKey, PublicKey);
        public static string BaseUrl => "http://gateway.marvel.com/v1/public/";
        private static string Md5(long ts, string privateKey, string publicKey)
        {
            string stringToHash = $"{ts}{privateKey}{publicKey}";
            MD5 cryptor = MD5.Create();
            byte[] bytes = cryptor.ComputeHash(Encoding.Default.GetBytes(stringToHash));
            string result = BitConverter.ToString(bytes).ToLower().Replace("-", "");
            return result;
        }
    }
}
