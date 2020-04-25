# String Input Dialog

[Return to Main Page](README.md)

![a sample image of the dialog][sample]

The string input dialog is a way for users to enter a string without needing to create a brand new dialog for every option. This dialog more or less mirrors the VBA version, but altered to be more user friendly. This dialog dynamically scales with the `Message` string so that there won't be cut-off (unless your string is an essay).

## Ways to use
StringInput is a dialog, which means it has to be initialized before being called. You can set the `Message` and optionally the `Title` of the form while initializing the form.
```csharp
var form = new StringInput("This is a sample dialog.", "Sample Title");
```
Additionally, you can set a preset value that will pre-fill the textbox using `SetDefaultInput(string Value)`.

### ShowDialog() vs Display()
This dialog can be shown to the user through two main methods. The first is `ShowDialog()` which acts normally. Alternatively, you can use `Display()`. The only difference is that ShowDialog returns a `DialogResult` while Display returns a `Boolean`. If you use ShowDialog, `DialogResult.OK` is passed if the user hits the submit button while `DialogResult.Cancel` is passed if the user his the cancel button or closes the dialog.

## Code Sample
The following is a sample where the user will be prompted to either confirm the file name provided or enter a new name.
```csharp
// file = A fileInfo dragged onto the source dialog.
// Get the name of the file without extension.
string fileNoExt = Path.GetFileNameWithoutExtension(file.Name);

// Create a new instance of the StringInput dialog.
StringInput input = new StringInput("Please confirm the file name of the dragged file or enter a new name.", "Confirm file name.");

// Set the default value of the input of the StringInput dialog.
input.SetDefaultInput(fileNoExt);

// Show the dialog and wait for the user to finish.
// Display() returns a bool while ShowDialog() returns DialogResult.
// Both options are valid ways to show the dialog.
if (input.Display()) {
    // If the user accepts the form (didn't close or cancel), set the value of fileNoExt to reflect change.
    fileNoExt = input.Input;
}
```

[sample]: https://i.imgur.com/rMWEzga.png
