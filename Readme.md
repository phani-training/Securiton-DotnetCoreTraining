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
2. Implement the classs for the Entity and DBContext, refer the CodeFirstApproach.cs file. 
3. Open the Package Manager Console and run the following commands:
	- add-migration migrationName-version
	- update-database
4. View the Server explorer to see the Generated database and Tables. 
5. Any modifications U do on the classes, U should run the above commands to get the newer versions of the Context Object.

### How to work using Dapper?
1. Dapper is a framework with Extension methods for IDBConnection interface to perform CRUD Operations on the databases in light weight manner. Unlike EF or any other ORMs, U dont need a heavy infra. It is called as Micro-ORM Framework.
2. It cannot be used for CODE-FIRST Approach.
3. U should create Entity classes based on the database Table design including relations. Dapper API will help in converting the raw data of Tables to Collection objects thru which you could perform the CRUD Operations. 
4. Steps on using Dapper API
    - Reference the Dapper Nuget Package in your project
    - Create a SqlConnection object with appropriate Connection String. 
    - Use the extension methods of the Dapper to perform your data related Operations
    - Query based methods are used for SELECT statements.
    - Execute Method is used for DELETE, UPDATE and INSERT Statements. It can also be used for DCL Operations. 
    - For performing transactions for ACID properties, U can either use the ADO.NET SqlTransaction using SqlConnection's BeginTranscation API or U could add new Nuget Package called Dapper.Transaction that will have Extension methods for SqlTransaction Class. 
