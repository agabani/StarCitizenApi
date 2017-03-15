using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace StarCitizenApi.ArkStarmap.Cache
{
    public class FileCache
    {
        public string Get(string endpoint, string body)
        {
            var fileName = $"C:\\Cache\\{FileName(endpoint, body)}";

            return File.Exists(fileName) ? File.ReadAllText(fileName, Encoding.UTF8) : null;
        }

        public void Put(string endpoint, string body, string content)
        {
            var fileName = FileName(endpoint);

            File.WriteAllText($"C:\\Cache\\{fileName}", content, Encoding.UTF8);
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
            {
                builder.Append(@byte.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}