using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.Helper
{
    public class LogHandler
    {
        private LogWriter logWriter;
        private static volatile LogHandler _instance;
        private static object _lock = new object();

        private LogHandler()
        {
            InitializeLogging();
        }

        private void InitializeLogging()
        {
            logWriter = new LogWriterFactory().Create();
            Logger.SetLogWriter(logWriter, false);
        }

        private LogWriter LogWriter
        {
            get
            {
                return logWriter;
            }
        }

        public static LogHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new LogHandler();
                        }
                    }
                }
                return _instance;
            }
        }

        public void WriteTraceLog(string message, TraceEventType type = TraceEventType.Information)
        {
            this.LogWriter.Write(message, "General", 5, 2000, type);
        }

    }
}
