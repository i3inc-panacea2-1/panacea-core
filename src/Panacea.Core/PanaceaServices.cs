using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public sealed class PanaceaServices
    {
        public PanaceaServices(
            IHttpClient client,
            IUserService userService,
            IPluginLoader pluginLoader,
            ILogger logger,
            IWebSocket webSocket,
            ISerializer serializer)
        {
            HttpClient = client ?? throw new ArgumentException("client");
            UserService = userService ?? throw new ArgumentException("userService");
            PluginLoader = pluginLoader ?? throw new ArgumentException("pluginLoader");
            Logger = logger ?? throw new ArgumentException("logger");
            WebSocket = webSocket ?? throw new ArgumentException("webSocket");
            serializer = serializer ?? throw new ArgumentException("serializer");
        }

        public IUserService UserService { get; }

        public IPluginLoader PluginLoader { get; }

        public IHttpClient HttpClient { get; }

        public ILogger Logger { get; }

        public IWebSocket WebSocket { get; }

        public ISerializer Serializer { get; }
    }
}
