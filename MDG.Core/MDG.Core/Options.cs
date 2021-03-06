﻿namespace MDG.Options
{
    public class General
    {
        public static string ProjectName = "My Project";
    }

    /// <summary>
    /// Options relating to the JobNumber module.
    /// </summary>
    public class JobNumber
    {
        // BaseDirectory
        // Change this to be the base path where all the jobs are stored.
        /// <summary>
        /// The base directory to search for GetPath method.
        /// </summary>
        public static string BaseDirectory = @"Z:\";
    }

    public class Log
    {
        public static bool ForceDebug = true;
    }
}