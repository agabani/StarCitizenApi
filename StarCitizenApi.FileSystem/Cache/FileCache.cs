using System.IO;
using System.Security.Cryptography;
using System.Text;
using StarCitizenApi.ArkStarmap.Cache;

namespace StarCitizenApi.FileSystem.Cache
{
    public class FileCache : ICache
    {
        private readonly string _cacheDirectory;

        public FileCache(CacheOptions options)
        {
            _cacheDirectory = $"{options.CacheLocation}\\Cache";

            if (!Directory.Exists(_cacheDirectory))
                Directory.CreateDirectory(_cacheDirectory);
        }

        public string Get(string endpoint, string body)
        {
            var filePath = FilePath(endpoint, body);

            return File.Exists(filePath) ? File.ReadAllText(filePath, Encoding.UTF8) : null;
        }

        public void Put(string endpoint, string body, string content)
        {
            File.WriteAllText(FilePath(endpoint, body), content, Encoding.UTF8);
        }

        private string FilePath(string endpoint, string body)
        {
            return $"{_cacheDirectory}\\{FileName(endpoint, body)}";
        }

        private static string FileName(string endpoint, string body = "")
        {
            byte[] computeHash;

            using (var md5 = MD5.Create())
            {
                computeHash = md5.ComputeHash(Encoding.UTF8.GetBytes($"{endpoint}{body}"));
            }

            var builder = new StringBuilder();

            foreach (var @byte in computeHash)
                builder.Append(@byte.ToString("x2"));

            return builder.ToString();
        }
    }
}