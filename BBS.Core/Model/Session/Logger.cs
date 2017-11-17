using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    public static class Logger
    {
        private static StringBuilder logBuilder = new StringBuilder();
        private static StringBuilder transactionLogBuilder = new StringBuilder();
        private static int MAX_LENGTH = 100000;

        public static void Log(string s)
        {
            Person p = Session.GetCurrentUser();

            if (p != null)
                logBuilder.Append(String.Format("[Log {0} {1}] ", p.Name, DateTime.Now.ToString()));

            logBuilder.Append(s);
            logBuilder.Append(Environment.NewLine);
        }

        public static void LogTransaction(string s)
        {
            Person p = Session.GetCurrentUser();

            if (p != null)
                transactionLogBuilder.Append(String.Format("[Log {0} {1}] ", p.Name, DateTime.Now.ToString()));

            transactionLogBuilder.Append(s);
            transactionLogBuilder.Append(Environment.NewLine);

            Log(s);
        }

        public static void Reset()
        {
            logBuilder = new StringBuilder();
            transactionLogBuilder = new StringBuilder();
        }

        public static string GetLog()
        {
            return logBuilder.ToString();
        }

        public static string GetTransactionLog()
        {
            return transactionLogBuilder.ToString();
        }

        public static void TrimContents()
        {
            transactionLogBuilder.Remove(0, (int)Math.Max(0,transactionLogBuilder.Length - MAX_LENGTH));
            logBuilder.Remove(0, (int)Math.Max(0, logBuilder.Length - MAX_LENGTH));
        }

        internal static StringBuilder LogBuilder
        {
            get
            {
                return logBuilder;
            }
            set
            {
                logBuilder = value;
                if (logBuilder == null)
                    logBuilder = new StringBuilder();
            }
        }
        internal static StringBuilder TransLog
        {
            get
            {         
                return transactionLogBuilder;
            }
            set
            {
                transactionLogBuilder = value;
                if (transactionLogBuilder == null)
                    transactionLogBuilder = new StringBuilder();
            }
        }
    }
}
