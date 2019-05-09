using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        Task<ServerResponse<T>> SetCookieAsync<T>(string name, T data);

        Task<ServerResponse<T>> GetCookieAsync<T>(string name);

        string RelativeToAbsoluteUri(string path);

        Task<byte[]> DownloadDataAsync(string url, CancellationTokenSource cts = null);
    }

    [DataContract]
    public class ServerResponse
    {
        [DataMember(Name = "success")]
        public Boolean Success { get; set; }

        [DataMember(Name = "error")]
        public string Error { get; set; }
    }


    [DataContract]
    public class ServerResponse<T> : ServerResponse
    {
        [DataMember(Name = "result")]
        public T Result { get; set; }
    }
}
