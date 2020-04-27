# Melbourne Design Group
For a reference cheat sheet, see [Reference Sheet](Reference.md)

Melbourne Design Group - Core Functions (shortened to MDG.Core) is a group of common functions used throughout the Melbourne Design Group suite of applications. These functions range anywhere from application logging to job number parsing and other useful items that we may need. The scope of industry revolves around Land Survey applications, but theoretically can be used in other applications as well.

## Getting Started

### Prerequisites
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/vs/)
 - Basic understanding of nuget package management **OR**
 - [Latest source code](https://github.com/NWhite421/MDG.Core/releases)

### Installing

#### NuGet Package Manager

Open the package manager under `Tools >> NuGet Package Manager >> Package Manager Console` and run the following code to download the latest version.
```
Install-Package MDG.Core -Version 0.2.0-alpha
```

If you want to install other versions of the package, choose from the [NuGet Package Page](https://www.nuget.org/packages/MDG.Core/).

#### Source Code

Download the source code from this [link](https://github.com/NWhite421/MDG.Core/releases/tag/0.2.0-alpha) and add it to your project folder. In Visual Studio, right-click on your project, select `Add Existing Project` and select `MDG.Core\Core.csproj`. Build the project and add the project to your main project's reference list.

## Setup

See [Project Setup](ProjectSetup.md) for information regarding setup.

## Deployment

This project will be built and deployed as a dependant for the master project.

## Features
- [Logging](Log.md)
- [String Input Dialog](STRINGINPUT.md)

## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - Base local framework

## Contributing

Please read [CONTRIBUTING](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/NWhite421/MDG.Core/tags). 

## Authors

* [**Nathan White**](https://github.com/NWhite421) - Project Lead

See also the list of [contributors](https://github.com/NWhite421/MDG.Core/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see [LICENSE](LICENSE.md)  for details
