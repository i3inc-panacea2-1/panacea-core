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
            IUserService userService,
            IPluginLoader pluginLoader)
        {
            UserService = userService;
            PluginLoader = pluginLoader;
        }

        public IUserService UserService { get; }

        public IPluginLoader PluginLoader { get; }

    }
}
