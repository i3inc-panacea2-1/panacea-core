using Panacea.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    /// <summary>
    /// Plugin management interface
    /// </summary>
    public interface IPluginLoader
    {
        /// <summary>
        /// Triggers when a plugin has been loaded.
        /// </summary>
        event EventHandler<IPlugin> PluginLoaded;

        /// <summary>
        /// Triggers before a plugin is about to be unloaded
        /// </summary>
        event EventHandler<IPlugin> PluginUnloaded;

        /// <summary>
        /// Gets a dictionary with keys the names of all loaded plugins and with values the instances of type <see cref="IPlugin"/>.
        /// </summary>
        IReadOnlyDictionary<string, IPlugin> LoadedPlugins { get; }

        /// <summary>
        /// Returns the directory where a plugin's files are stored
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        string GetPluginDirectory(string pluginName);

        /// <summary>
        /// Returns a list of loaded plugins that implement T.
        /// </summary>
        /// <typeparam name="T">IPlugin</typeparam>
        /// <returns>The list (possible empty) of loaded plugins of type T.</returns>
        IEnumerable<T> GetPlugins<T>() where T : IPlugin;

        /// <summary>
        /// Returns a single plugin of type T. If no plugins of type T are loaded, it should throw a <see cref="PluginNotLoadedException"/>. 
        /// If multiple plugins of the same type are loaded, it should throw <see cref="MultiplePluginsLoadedException"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetPlugin<T>() where T : IPlugin;

        event EventHandler LoadStarting;

        event EventHandler LoadFinished;
    }
}
