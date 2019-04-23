using System;

namespace Panacea.Core
{
    public interface ISerializer
    {
        T Deserialize<T>(string text);

        object Deserialize(string text, Type t);

        string Serialize<T>(T obj);
    }
}
