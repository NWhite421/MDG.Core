using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDG.Core
{
    public class Paths
    {
        /// <summary>
        /// Replaces the variables in a string with their dynamic counterpart.
        /// </summary>
        /// <param name="Input">String to replace variables in.</param>
        /// <returns>String with updated variables.</returns>
        public static string ReplaceVariables(string Input)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dateCurrent = DateTime.Now;
            string dateFull = dateCurrent.ToString("MM-dd-yy hh-mm-ss tt");
            string dateShort = dateCurrent.ToString("MM-dd-yy");
            string time = dateCurrent.ToString("hh-mm-ss");

            string outp = Input.Replace("$LocalAppData$", localAppData)
                .Replace("$AppData$", appData)
                .Replace("$ProjectName$", Options.General.ProjectName)
                .Replace("$DateFull$", dateFull)
                .Replace("$DateShort$", dateShort)
                .Replace("$Time$", time);

            return outp;
        }
    }
}
