# Project Setup

[Return to Main Page](README.md)

MDG.Core was designed to be simple to setup and operate. As such, there is very little you need to do in order to deploy this assembly into your project. The biggest consideration is setting your `OPTIONS` variables to be in line with your requirements. This can be done either through your existing initialization method or calling another method purely for setting the variables. The options are categorized to mirror their modules, with the `GENERAL` category being the only option set to be common throughout. This means if you enable `DEBUG` options in `LOGGING` but not in `PATHS`, only logging will be switched. For more information, see the specific module's page.

If you fail to properly set all required conditions, the program will throw a `Log.AddError` and either throw it (debug) or create a crash report (in release). It is recommended that you copy the code in the [sample](#Sample-Initialization-Method) to ensure all your options are set and allow a smooth deployment.

## Sample Initialization Method
```csharp
// Sample MDG.Core initialization of variables and other things.
//      Written by: NBW
//      Updated:    Apr. 26, 2020
//      Version:    0.3.0-alpha
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
```