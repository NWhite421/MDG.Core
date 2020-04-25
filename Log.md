# Logging

[Return to Main Page](README.md)

logging is the first issue I wanted to tackle with this project. For every project I would create, the ways I handled logging and reporting in both debug and release varied drastically. The goal of this module is to consistently be able to log both debug information and general application information, warning, and errors.

## Debug vs Release
The first thing I wished to do was to create a way that when I am debugging, I am not creating log files for every test run, rather using the `Debug Output` log as an alternative. Therefore, there are three modes that the logging features use that make this more beneficial than manually writing `Debug.WriteLine` or to a arbitrary log.

### ToDebug
The `ToDebug` is, more or less the `Debug.WriteLine` function with the added benefit of a timestamp at the beginning of the entry. This function works **ONLY** in Debug config, and does nothing if in a non-debug configuration. This allows you to add these calls all throughout your code and not have to worry about release log spamming.

### AddInfo, AddWarning, AddError
These methods are dynamic methods for logging and vary in what they do depending on which config the project is running. Additionally, they are bounded by the `(boolean)MDG.Options.Log.ForceDebug` option. When the program is in `DEBUG` configuration, these methods output to the `Debug Output` window with their appropriate tag (info, warning, error). This way, when you are debugging, all the information for logging is located in one place and clutter is no more.

When you are in `RELEASE` config, the `ForceDebug` option comes into play. If this option is set to true, the behavior reverts to the `DEBUG` config, preventing logs from being written. If this option is set to false, the program creates a .log file on every run and the info/warning/error entries are written to that file.

## Remarks
This module is currently in alpha, and is still being written (as of Apr. 25 2020). The logging feature is not complete and is still be written.