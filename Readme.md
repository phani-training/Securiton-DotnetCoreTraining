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
2. Implement the classs for the Entity and DBContext, refer the CodeFirst.cs file. 
3. Open the Package Manager Console and run the following commands:
	- add-migration migrationName-version
	- update-database
4. View the Server explorer to see the Generated database and Tables. 

### New Features of .NET Framework. 
 - Using var keyword.
 	- We use var to define local variables. It is convinient way of declaring the variables. 
        - U should assign the variable with a value before U move further. This assignment defines the data type of the var. 
        - It is implicit typed variable => This variable will hold the type based on the value U assign it  during declaration. Hense forth, it will follow the norms of the typical data type of .NET. 
        - var is convinient to be used in LINQ Expressions, Lamdba Expressions and Anonymous types which are all the new features introduced in .NET 3.0. 	 
 - Using Lambda Expressions
 	- Delegate is a reference type in .NET that can be used to create reference variables to functions. 
        - Using delegate keyword we declare a delegate with a specific Method signature.
        - Func and Action are 2 important Generic delegates that can be used for Return Type Functions and void Functions respectively.
        - Practically, Delegates are used in Event Handling, CallBack Functions, Multi Threading, Async Programming. 
        - In .NET 2.0, we got Anonymous methods where we could use delegate keyword to implement a method with no name and map to the delegate instance.
        - In .NET 3.0 and later, we got the Lambda Expression syntax where we dont use anonymous methods syntax, rather achieve the same using => Operator called as Lambda Operator or Arrow Operator  	
 - Using Extension methods.
 	- Extension methods are static methods. Its first parameter will be a this operator followed by the class instance that U want to extend this method. It can be followed by regular arguments required for the method.
	- Functions are to be static. Extension methods are added to the object of the class, not to the class itself. So Runtime polymorphism and other Features of OOP are not applicable on these methods.
 - Using LINQ.
### ASP.NET Core Environment
### ASP.NET MVC Application. 
### Web API Development using .NET CORE.
6. Any modifications U do on the classes, U should run the above commands to get the newer versions of the Context Object.

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
