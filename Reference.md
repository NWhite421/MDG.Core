# Reference Sheet
The following is a quick reference sheet for the current release of the code.
## Logging
### ToDebug
Allows the user to write a string message to the debug output log. Does nothing in `RELEASE` config.
Format: 
```csharp
MDG.Core.Log.ToDebug(string Input);
```
Arguments
```
(0) Input: The string to add to the debug output log.
```
Return: Void
### AddInfo
Allows the user to write a string message to the active output log. In `DEBUG` config, the active log is the Debug Output log. In `RELEASE` config, the active log is the permanent .log file [To be implemented].
Format: 
```csharp
MDG.Core.Log.AddInfo(string Input);
```
Arguments
```
(0) Input: The string to add to the debug output log.
```
Return: Void
### AddWarning
Allows the user to write a string message to the active output log. In `DEBUG` config, the active log is the Debug Output log. In `RELEASE` config, the active log is the permanent .log file [To be implemented]. A warning will not stop the program.
Format: 
```csharp
MDG.Core.Log.AddWarning(string Input);
```
Arguments
```
(0) Input: The string to add to the debug output log.
```
Return: Void
### AddError
Allows the user to write a string message to the active output log. In `DEBUG` config, the active log is the Debug Output log. In `RELEASE` config, the active log is the permanent .log file [To be implemented]. An error will stop the program.
Format: 
```csharp
MDG.Core.Log.AddError(string Input);
```
Arguments
```
(0) Input: The string to add to the debug output log.
```
Return: Void (Will throw a `CustomErrorException`).
## JobNumber
### TryParse
Attempt to parse the input string to determine if it is a valid job number format. If desired, the user can output a re-formatted string of the job number
#### Method One
Format
```csharp
MDG.Core.JobNumber.TryParse(string Input);
```
Arguments
```
(0) Input: String to attempt to parse.
```
Return: Boolean (True if is a job number, False if not).
#### Method Two
Format
```csharp
MDG.Core.JobNumber.TryParse(string Input, out string FormatNumber, JobNumberFormats Format);
```
Arguments
```
(0) Input: String to attempt to parse.
(1) FormatNumber: Output string of re-formatted number.
(2) Format: Format to re-format number to.
```
Return: Boolean (True if is a job number, False if not).
Remarks:
JobNumberFormats can be
```
JobNumberFormats.ShortHyphan
JobNumberFormats.ShortNoHyphan
JobNumberFormats.LongHyphan
JobNumberFormats.LongNoHyphan
```
