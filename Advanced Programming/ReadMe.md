# Advanced Web API Tutorial
### Minimal Web API
- Normal Web API development needs the usage of  controllers, lot of dependencies, un-nessalary largge list of files and huge code base to implement even a single end point. 
- With Minimal Web API U cah develop the Service with least possible lines of code, minimal dependencies and and extend the application features on an need basis. 
- Works similar to the way EXPRESS.JS works on a NODEJS Environment. 
- Web API core uses the builder pattern to implement these features. 
- WebApplicationBuilder will help in building UR Application like Services, Configurations, Environments and many more. 
- Web API core has one of the highest performance parameters met in the industry. 
- Web server will be Kestral, Linux web server based on Apache. 
- Steps for creating the Application using dotnet CLI. 
    1. Check the version of the .NET using CLI: dotnet --version
    2. Run the command: dotnet new webapi -minimal -o OutputDir
    3. Build UR Application with sample code shared. 
    4. Run the Application using dotnet run
- For Complex Apps that has encriptions, Cloud based Data rendering, then U cannot mix all the code in the minimal APIs. 
### Language Enhancements in C#.
#### Using Records
- Record types are value types or reference types that allows to create Immutable properties.
- New in .NET 8, U can declare records at the namespace level.
- We can create record with class or struct. 
- U can achieve inheritance with Record classes but not with structs. 
- By default all properties are default with init. This provides built in support for Immutability. 
- U have builtin support for the displaying the data like JSON object. 
#### Init Only setters
- Init will replace set block  if U want to set the value only once durin the instantiation of the object. 
- set block allows to modify the property after the object is created, but with init setters, U can do that only once. They are modified version of readonly properties. 
#### Pattern matching:
- Pattern matching is used to test for certain valus and conditions. We used to use the switch and if claues for this purpose. With C# 11, we can achive this as expressions. 
- Makes the code more robust and easy to understand. 
- Null patterns, Const patterns, property patterns, Nagating Patterns, Type patterns are some of the pattern matchings we do in C# 9.0
#### Top Level Statements:
- No need to create an Entry point in C# 10. U can make statements directly into the file without any Main Function or blocks. 
#### Native sized Integers
- Now integers can have range and size compliant to the word size on the CPU architecture. This is helpful for interop services where the data will be 32 bit values. 
- If the software is running on a 32 Bit platform, it will be 32 bit in size and range.  
- We can use new data types called nint for achieving this feature. 
nint is called as native integer. 
- It behaves like int but takes the size basd on the CPU the App executes.  
#### Function pointers
#### Ref Fields and Ref Scoped members
- Used when U want fields to be modifiable outside the class thru other functions.
#### Static Anonmymous methods
#### Required Members. 
#### Raw literal strings. 
### Implementing JWT for Web API Security.
