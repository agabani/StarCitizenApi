using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<string> Get(string endpoint, string body)
        {
            var filePath = FilePath(endpoint, body);

            if (!File.Exists(filePath))
                return null;

            using (var fileStream = File.Open(FilePath(endpoint, body), FileMode.Open))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    return await streamReader.ReadToEndAsync();
                }
            }
        }

        public async Task Put(string endpoint, string body, string content)
        {
            using (var fileStream = File.Open(FilePath(endpoint, body), FileMode.Create))
            {
                using (var streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    await streamWriter.WriteAsync(content);
                }
            }
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