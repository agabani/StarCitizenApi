using System.Security.Cryptography;
using System.Text;
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

        public string Get(string endpoint, string body)
        {
            var blockBlobReference = _container
                .GetBlockBlobReference(FileName(endpoint, body));

            return blockBlobReference.Exists()
                ? blockBlobReference.DownloadText(Encoding.UTF8)
                : null;
        }

        public void Put(string endpoint, string body, string content)
        {
            _container
                .GetBlockBlobReference(FileName(endpoint, body))
                .UploadText(content, Encoding.UTF8);
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