using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{

    public abstract class HttpServiceBase
    {
        protected readonly IHttpClient _client;

        public HttpServiceBase(IHttpClient client)
        {
            _client = client ?? throw new ArgumentNullException("client");
        }

        protected T ThrowIfError<T>(ServerResponse<T> response)
        {
            if (response.Success)
                return response.Result;

            throw new ServerResultException(response);
        }
    }

    public class ServerResultException : Exception
    {
        public ServerResponse Response { get; }

        public ServerResultException(ServerResponse response) : base(response.Error)
        {
            Response = response;
        }

        public ServerResultException(ServerResponse response, Exception ex) : base(response.Error, ex)
        {
            Response = response;
        }
    }

}
