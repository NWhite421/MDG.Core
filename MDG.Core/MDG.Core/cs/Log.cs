﻿using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MDG.Core
{
    public class Log
    {
        internal static bool FirstLog = true;

        #region INTERNAL METHODS
        /// <summary>
        /// Gets the date tage for the log entry.
        /// </summary>
        /// <returns>[yyyy-mm-dd hh:mm:ssz] in 24 hr format.</returns>
        private static string GetDateTag()
        {
            var date = DateTime.Now.ToString("G");
            return $"[{date}]";
        }

        private static void OutputAssemblyInfo()
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string compileDate = File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToString("G");
#if DEBUG
            string config = "DEBUG";
#else
            string version = "RELEASE";
#endif
            Debug.WriteLine($"MDG Core loaded\n" +
                $"============================================\n" +
                $"Version: {version}\n" +
                $"Config: {config}\n" +
                $"Build date: {compileDate}\n" +
                $"============================================");
        }

        private static void WriteToDebugLog(string Message, LogLevels Level)
        {
            if (FirstLog)
            {
                OutputAssemblyInfo();
                FirstLog = false;
            }
            Debug.WriteLine($"[{Level}]{GetDateTag()}: {Message}");
        }

        private static void WriteToLog(string Message, LogLevels Level)
        {
#if DEBUG
            if (FirstLog)
            {
                OutputAssemblyInfo();
                FirstLog = false;
            }
            WriteToDebugLog(Message, Level);
#else
            if (FirstLog)
            {
                OutputAssemblyInfo();
                FirstLog = false;
            }
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
