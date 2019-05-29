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
    }
}
