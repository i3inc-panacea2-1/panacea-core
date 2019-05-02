using Panacea.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public class PluginNotLoadedException : Exception
    {
        public Type Type { get; }

        internal PluginNotLoadedException(Type type) : base($"Plugin of type '{type.FullName}' was requested but not currently loaded")
        {
            Type = type;
        }
    }

    public class PluginNotLoadedException<T> : PluginNotLoadedException where T : IPlugin
    {
        public PluginNotLoadedException() : base(typeof(T))
        {

        }
    }


    public class MultiplePluginsLoadedException : Exception
    {
        public Type Type { get; }

        internal MultiplePluginsLoadedException(Type type) : base($"Plugin of type '{type.FullName}' was requested but not currently loaded")
        {
            Type = type;
        }
    }

    public class MultiplePluginsLoadedException<T> : PluginNotLoadedException where T : IPlugin
    {
        public MultiplePluginsLoadedException() : base(typeof(T))
        {

        }
    }
}
