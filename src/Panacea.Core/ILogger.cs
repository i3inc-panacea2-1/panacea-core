using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public interface ILogger
    {
        IReadOnlyCollection<Log> Logs { get; }
        void Log(LogVerbosity verbosity, string sender, string message, object payload = null);
        void Log(LogVerbosity verbosity, object sender, string message, object payload = null);
        void Debug(object sender, string message, object payload = null);
        void Debug(string sender, string message, object payload = null);
        void Warn(object sender, string message, object payload = null);
        void Warn(string sender, string message, object payload = null);

        void Error(object sender, string message, object payload = null);
        void Error(string sender, string message, object payload = null);

        void Info(object sender, string message, object payload = null);
        void Info(string sender, string message, object payload = null);

        void Wtf(object sender, string message, object payload = null);
        void Wtf(string sender, string message, object payload = null);

        event EventHandler<Log> OnLog;
    }

    public class Log
    {
        public DateTime Time { get; private set; }
        public Log(string sender, string message, LogVerbosity logType = LogVerbosity.Debug, object payload = null)
            : this()
        {
            Sender = sender;
            Message = message;
            Verbosity = logType;
            Verbosity = logType;
            Payload = payload;
        }
        public Log()
        {
            Time = DateTime.Now;
        }

        public LogVerbosity Verbosity { get; set; }

        public string Sender { get; set; }
        public string Message { get; set; }

        public object Payload { get; set; }
    }

    public enum LogVerbosity
    {
        Info,
        Debug,
        Warning,
        Error,
        Wtf
    }
}
