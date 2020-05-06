using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MDG.Core
{
    public class Log
    {
        internal static bool FirstLog = true;
        internal static string LogPath;

        internal static DebugLog DebugWindow;

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

        private static void OutputAssemblyInfo(int OutputMode)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string compileDate = File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToString("G");
            if (OutputMode == 0)
            {
                string config = "DEBUG";
                Debug.WriteLine($"MDG Core loaded\n" +
                    $"============================================\n" +
                    $"Version: {version}\n" +
                    $"Config: {config}\n" +
                    $"Build date: {compileDate}\n" +
                    $"============================================");
            }
            else if (OutputMode == 1)
            {
                if (string.IsNullOrEmpty(LogPath))
                {
                    Log.AddError("Log path could not be found.");
                    return;
                }
                string config = "RELEASE";
                string line = $"MDG Core loaded\n" +
                    $"============================================\n" +
                    $"Version: {version}\n" +
                    $"Config: {config}\n" +
                    $"Build date: {compileDate}\n" +
                    $"============================================";
                File.AppendAllLines(LogPath, new List<string> { line });
            }
            else if (OutputMode == 2)
            {
                if (string.IsNullOrEmpty(LogPath))
                {
                    Log.AddError("Log path could not be found.");
                    return;
                }
                string config = "RELEASE [Forced Debug]";
                string line = $"MDG Core loaded\n" +
                    $"============================================\n" +
                    $"Version: {version}\n" +
                    $"Config: {config}\n" +
                    $"Build date: {compileDate}\n" +
                    $"============================================";
                DebugWindow = new DebugLog();
                DebugWindow.Show();
                DebugWindow.AddToLog(line);
            }
        }

        private static void EstablishLogFile()
        {
            string path = Paths.ReplaceVariables(Options.Log.StoragePath);
            string baseDir = Directory.GetParent(path).FullName;
            Log.ToDebug(path + "\n" + baseDir);

            if (!Directory.Exists(baseDir))
            {
                Directory.CreateDirectory(baseDir);
            }
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string logFile = Path.Combine(path, Paths.ReplaceVariables("$ProjectName$ $DateFull$.log"));
            var stream = File.Create(logFile);
            stream.Close();
            LogPath = logFile;
        }

        private static void WriteToDebugLog(string Message, LogLevels Level)
        {
            if (FirstLog)
            {
                OutputAssemblyInfo(0);
                FirstLog = false;
            }
            Debug.WriteLine($"[{Level}]{GetDateTag()}: {Message}");
        }

        private static void WriteToLog(string Message, LogLevels Level)
        {
#if DEBUG
            if (FirstLog)
            {
                OutputAssemblyInfo(0);
                FirstLog = false;
            }
            WriteToDebugLog(Message, Level);
#else
            if (Options.Log.EnableDebug || Options.Log.DisableLog)
            {
                if (FirstLog)
                {
                    OutputAssemblyInfo(2);
                    FirstLog = false;
                }
                DebugWindow.AddToLog($"[{Level}]{GetDateTag()}: {Message}");
            }
            else
            {
                if (FirstLog)
                {
                    EstablishLogFile();
                    OutputAssemblyInfo(1);
                    FirstLog = false;   
                }
                if (string.IsNullOrEmpty(LogPath))
                {
                    Log.AddError("A log file could not be created.");
                    return;
                }
                File.AppendAllLines(LogPath, new List<string> { $"[{Level}]{GetDateTag()}: {Message}" });
            }
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
#if DEBUG
            WriteToDebugLog(Message, LogLevels.Info);
#else
            if (Options.Log.EnableDebug)
            {
                WriteToDebugLog(Message, LogLevels.Info);
            }
            else
            {
                WriteToLog(Message, LogLevels.Info);
            }
#endif
        }

        /// <summary>
        /// Write <paramref name="Message"/> to the log with time stamp.
        /// </summary>
        /// <param name="Message">Message to show.</param>
        public static void AddWarning(string Message)
        {
#if DEBUG
            WriteToDebugLog(Message, LogLevels.Warning);
#else
            if (Options.Log.EnableDebug)
            {
                WriteToDebugLog(Message, LogLevels.Warning);
            }
            else
            {
                WriteToLog(Message, LogLevels.Warning);
            }
#endif
        }

        /// <summary>
        /// Write <paramref name="Message"/> to the log with time stamp.
        /// </summary>
        /// <param name="Message">Message to show.</param>
        public static void AddError(string Message)
        {
            var excep = new CustomErrorException(Message);
            string output = "=============================================\n" +
                $"!! A critical exception has occured !!\n" +
                $"=============================================\n" +
                $"Message: {Message}\n" +
                $"Date: {DateTime.Now:G}\n" +
                $"=============================================\n";
#if DEBUG
            Debug.WriteLine(output);
            throw excep;
#else
            if (Options.Log.EnableDebug)
            {
                Debug.WriteLine(output);
            }
            else
            {
                WriteToLog(Message, LogLevels.Warning);
            }
#endif
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

    /// <summary>
    /// Custom error exception thrown in AddError method.
    /// </summary>
    class CustomErrorException: Exception
    {
        public CustomErrorException()
        {

        }
        
        public CustomErrorException(string Message)
            : base($"Cusom error thrown: {Message}")
        {

        }
    }
}
