# Dotnet Core
### What is .NET Core?
.NET Core is a framework and a platform for developing .NET Apps across multiple platforms. It is a new framework with some features taken from .NET Framework. With .NET, U can develop Web based, Terminal based, Database based, Service based Applications. It can be executed on any platforms,like Linux and Mac. It is Open sourced and its Github link provides capability to explore, and extend UR development on it. 

### How to develop these Applications?
- U should have .NET CORE installed in your machine. 
- For Windows Users, its available as a part of the OS Shippment. 
- For Linux Users, U can download from the Microsoft Downloads Folder that provides links to download the software as a package. 
- For the IDE, U can use VS Code and Visual Studio.
- U can use the .NET CLI or Command line Utilities that can be executed from the Command prompt to develop the boiler plate code from which U could extend it or customize it. 

### Steps for creating .NET Apps:
1. Open the Command prompt and test if .NET CORE is installed in your machine. 
2. Run the following command: 
```
dotnet --version.
```
3. To create a Console App,U can run the following command:
```
dotnet new console -n SampleCoreApp
```

### How to Create EF Core App with CF Approach
1. Install the following Nuget Packages in your Project:
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Tools.