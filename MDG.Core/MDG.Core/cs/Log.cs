using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MDG.Core
{
    public class Log
    {
        #region INTERNAL METHODS
        /// <summary>
        /// Gets the date tage for the log entry.
        /// </summary>
        /// <returns>[yyyy-mm-dd hh:mm:ssz] in 24 hr format.</returns>
        private static string GetDateTag()
        {
            var date = DateTime.Now.ToString("u");
            return $"[{date}]";
        }

        private static void WriteToDebugLog(string Message, LogLevels Level)
        {
            Debug.WriteLine($"{Level}{GetDateTag()}: {Message}");
        }

        private static void WriteToLog(string Message, LogLevels Level)
        {
#if DEBUG
            WriteToDebugLog(Message, Level);
#else
            WriteToDebugLog(Message, Level);
            //TODO: Add permanent logging for Log.WriteToLog function
#endif
        }
        #endregion

        #region PUBLIC METHODS
        /// <summary>
        /// Write <paramref name="Message"/> to the debug output with time stamp.
        /// </summary>
        /// <param name="Message">Message to show.</param>
        public static void ToDebug(string Message)
        {
            WriteToDebugLog(Message, LogLevels.Debug);
        }

        /// <summary>
        /// Write <paramref name="Message"/> to the log with time stamp.
        /// </summary>
        /// <param name="Message">Message to show.</param>
        public static void AddInfo(string Message)
        {
            WriteToDebugLog(Message, LogLevels.Info);
        }

        /// <summary>
        /// Write <paramref name="Message"/> to the log with time stamp.
        /// </summary>
        /// <param name="Message">Message to show.</param>
        public static void AddWarning(string Message)
        {
            WriteToDebugLog(Message, LogLevels.Warning);
        }

        /// <summary>
        /// Write <paramref name="Message"/> to the log with time stamp.
        /// </summary>
        /// <param name="Message">Message to show.</param>
        public static void AddError(string Message)
        {
            WriteToDebugLog(Message, LogLevels.Error);
        }
        #endregion
    }

    /// <summary>
    /// Levels of logging
    /// </summary>
    public enum LogLevels
    {
        /// <summary>
        /// Debug information.
        /// </summary>
        Debug,
        /// <summary>
        /// General information.
        /// </summary>
        Info,
        /// <summary>
        /// Information thrown that is an issue but should not stop the program.
        /// </summary>
        Warning,
        /// <summary>
        /// Information thrown that is an issue and should stop the program.
        /// </summary>
        Error
    }
}
