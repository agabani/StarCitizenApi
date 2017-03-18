using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using StarCitizenApi.ArkStarmap.Cache;

namespace StarCitizenApi.WindowsAzure.Cache
{
    public class BlobCache : ICache
    {
        private readonly CloudBlobContainer _container;

        public BlobCache(CacheOptions options)
        {
            var storageAccount = CloudStorageAccount.Parse(options.ConnectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
            _container = blobClient.GetContainerReference(options.Container);
            _container.CreateIfNotExists();
        }

        public async Task<string> Get(string endpoint, string body)
        {
            var blockBlobReference = _container
                .GetBlockBlobReference(FileName(endpoint, body));

            return blockBlobReference.Exists()
                ? await blockBlobReference.DownloadTextAsync(Encoding.UTF8, null, null, null)
                : null;
        }

        public async Task Put(string endpoint, string body, string content)
        {
            await _container
                .GetBlockBlobReference(FileName(endpoint, body))
                .UploadTextAsync(content, Encoding.UTF8, null, null, null);
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