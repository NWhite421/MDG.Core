// Sample MDG.Core initialization of variables and other things.
//      Written by: NBW
//      Updated:    Apr. 26, 2020
//      Version:    0.3.0-alpha
namespace MDG.Core {
    public class Setup {
        public void InitMDGCore() 
        {
            // GENERAL SECTION
            // The project name to be used throughout MDG.Core
            MDG.Options.General.ProjectName = "My Project";

            // The company name to be used throughout MDG.Core
            MDG.Options.General.CompanyName = "My Company";

            // LOGGING SECTION
            // Enable the debug console output.
            MDG.Options.Logging.EnableDebug = false;

            // The save location of the .log files
            MDG.Options.Logging.StoragePath = @"$LocalAppData$\$ProjectName$\Logs";

            // JOB NUMBER SECTION
            // Sets the base job directory to form paths.
            MDG.Options.JobNumber.BaseDirectory = @"Z:\";
        }
    }
}