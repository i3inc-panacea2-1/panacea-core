using System;
using System.Collections.Generic;
using System.Linq;
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
            ILogger logger)
        {
            HttpClient = client;
            UserService = userService;
            PluginLoader = pluginLoader;
            Logger = logger;
        }

        public IUserService UserService { get; }

        public IPluginLoader PluginLoader { get; }

        public IHttpClient HttpClient { get; }

        public ILogger Logger { get; }

    }
}
