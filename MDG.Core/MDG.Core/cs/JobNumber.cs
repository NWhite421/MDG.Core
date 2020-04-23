using System;
using System.IO;
using System.Diagnostics;

namespace MDG.Core
{
    class JobNumber
    {
        /*public static bool TryParse(String Input, object Format, out string FormattedString)
        {

        }

        /// <summary>
        /// Return the full path of the Job Number directory
        /// </summary>
        /// <param name="JobNumber">Job number to find.</param>
        /// <returns>string of path or null if not found.</returns>
        public static string GetPath(string JobNumber)
        {
            //Base variables setup
            string dir = Options.JobNumber.BaseDirectory;

            //Error checks
            if (!TryParse(JobNumber, xxx, out string fullNumber))
            {
                Log.AddWarning($"Job number {JobNumber} failed to correctly parse.");
                return null;
            }

            if (!Directory.Exists(dir))
            {
                Log.AddWarning($"base path \"{dir}\" does not exist.");
                return null;
            }


            string[] parts = fullNumber.Split('-');
            dir = Path.Combine(dir, $@"{parts[0]}\{parts[1]}-{parts[0]}\{parts[1]}-{parts[2]}");

            if (!Directory.Exists(dir))
            {
                Log.AddWarning($"Path \"{dir}\" does not exist.");
                return null;
            }

            return dir;
        }*/
    }
}
