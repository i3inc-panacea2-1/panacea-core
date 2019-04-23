using Panacea.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public interface IPluginLoader
    {
        event EventHandler<IPlugin> PluginLoaded;

        event EventHandler<IPlugin> PluginUnloaded;

        /// <summary>
        /// Gets a dictionary with keys the names of all loaded plugins and with values the instances of type <see cref="IPlugin"/>.
        /// </summary>
        IReadOnlyDictionary<string, IPlugin> LoadedPlugins { get; }

        string GetPluginDirectory(string pluginName);

        IEnumerable<T> GetPlugins<T>() where T : IPlugin;
    }
}
