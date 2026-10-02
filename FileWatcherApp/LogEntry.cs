using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherApp
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string EventType { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"[{Timestamp:yyyy-MM-dd HH:mm:ss}] [{EventType}] {Message}";
        }
    }
}
