namespace MDG.Options
{
    public class General
    {
        public static string ProjectName = "My Project";

        public static string Company = "My Company";

        public class UserInformation
        {
            public static string UserName = "";

            public static AccessLevel AccessLevel = AccessLevel.User;
        }
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

    public enum AccessLevel
    {
        User,
        Manager,
        Administrator,
        Owner
    }

    public class Log
    {
        /// <summary>
        /// Force debug output when in <code>RELEASE</code> configuration.
        /// </summary>
        public static bool EnableDebug = true;

        public static bool DisableLog = false;

        /// <summary>
        /// The path to the log storage folder.
        /// </summary>
        public static string StoragePath = @"$LocalAppData$\$ProjectName$\Logs";
    }
}