using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public interface IHttpClient
    {
        Task<ServerResponse<T>> GetObjectAsync<T>(
                string url,
                List<KeyValuePair<string, string>> postData = null,
                Dictionary<string, byte[]> files = null,
                bool allowCache = true,
                CancellationTokenSource cts = null);

        Task<string> GetStringAsync(
            string url,
            List<KeyValuePair<string, string>> postData = null,
            Dictionary<string, byte[]> files = null,
            bool allowCache = true,
            CancellationTokenSource cts = null);

        Task<ServerResponse<T>> SetCookieAsync<T>(string name, T data);

        Task<ServerResponse<T>> GetCookieAsync<T>(string name);

        string RelativeToAbsoluteUri(string path);

        string GetApiEndpoint(string path);

        Task<byte[]> DownloadDataAsync(string url, CancellationTokenSource cts = null);
    }

    public abstract class ServerResponse
    {
        public virtual bool Success { get; set; }

        public virtual string Error { get; set; }
    }

    public abstract class ServerResponse<T> : ServerResponse
    {
        public virtual T Result { get; set; }
    }
}
