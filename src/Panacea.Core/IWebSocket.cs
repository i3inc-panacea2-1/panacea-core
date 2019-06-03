using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public interface IWebSocket
    {
        void On<T>(string _event, Action<T> act);

        void Remove(string verb, object action);

        void Emit<T>(string verb, T obj, bool addToQueue = true);
        void PopularNotify(string pluginName, string modelName, string id, string userID = "");
        void PopularNotifyPage(string pluginName, string itemAction = null, string modelName = "", string id = "", string userID = "");
    }
}
