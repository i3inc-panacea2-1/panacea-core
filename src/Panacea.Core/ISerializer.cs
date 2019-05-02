using System;

namespace Panacea.Core
{
    /// <summary>
    /// Interface for object serialization/deserialization
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Desrialize to an object of type T from string.
        /// </summary>
        /// <typeparam name="T">The deserialized object</typeparam>
        /// <param name="text">The serialized string</param>
        /// <returns></returns>
        T Deserialize<T>(string text);

        /// <summary>
        /// Deserialize to an object
        /// </summary>
        /// <param name="text">The serialized string</param>
        /// <param name="t">The type of the object to serialize to</param>
        /// <returns></returns>
        object Deserialize(string text, Type t);

        /// <summary>
        /// Serialize an object
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="obj">The object</param>
        /// <returns>The serialized object</returns>
        string Serialize<T>(T obj);
    }
}
