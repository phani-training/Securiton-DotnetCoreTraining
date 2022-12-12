API Implementation Best practises:
https://learn.microsoft.com/en-us/azure/architecture/best-practices/api-implementation

Common Challenges That C# Guidelines Can Address:
As a beginner, you can expect to face some difficulties while working on programs using C#. Below are some of the common issues that C# newcomers frequently face, but they can all be overcome if you adhere to the program’s best practices. By noting these potential problems and following C# guidelines, you will be taking an important step toward avoiding them.

Using a Reference Like a Value
In C#, the programmer who writes the object is the only one who can decide on the state of the values. That is, they can determine if the values assigned to variables are simply values or if they are references to existing objects. This is one of the most common mistakes new C# programmers make.

Using “Var” Needlessly
“Var” is very useful when it comes to dealing with unknown data types or an unexpected return of data. However, it is bad practice to overuse it. It is easy to keep using “var” in an attempt to save time, but it will negatively affect your code readability and will make it difficult for other programmers to use or maintain the code you’ve written.

Memory Leaks
It is normal to have memory or resource leaks in a program, which is why C# has a built-in method to dispose of these objects that are no longer in use. It is designed so that you only have to set or call an object in order to dispose of it. This helps to prevent memory leaks.

Using Iterative Statements to Manipulate Collections
Language-Integrated Query (LINQ) is used to manipulate and query collections, making it almost unnecessary for you to use iterative statements. So, if you get to the point of using iterative statements in your code, you have missed your chance to use LINQ.

Using Public Class Variables Instead of Properties
You should avoid using public class variables instead of properties because you can control who sets a property with object-oriented programming properties, but you lose that control if you use public class variables.

Top 10 C# Best Practices and Guidelines:
Use the Right Naming Conventions
Naming conventions show consistency in your code, so it’s important to use the right ones. C# is a case-sensitive programming language, with three naming conventions that are generally used: camel case convention, pascal case convention, and Hungarian case convention. Pascal case convention is when the first character of all words is uppercase and the others are lowercase, for example, PascalCaseConvention. Camel case convention is when the first character of all words is uppercase except the first word, as in, camelCaseConvention.

Choose Between Value Types and Reference Types
When working on a C# program, you need to decide what type you want to use: value or reference types. Value types are commonly used when storing data, while reference types are used to create an instance of your type when defining the behavior. Reference types are polymorphic, while value types are great for memory use.
Value type variables are used to keep the original copy of a variable and to protect it from any unexpected changes, while reference types change the variable completely.

Use Properties Instead of Public Variables
Using properties instead of public variables keeps your code contained in an OOP environment and makes data validation easier. With properties, you can utilize getters and setters to prevent the user from directly accessing the member variables. If you explicitly restrict setting the values, you will be protecting your data from accidental changes.

Don’t Reinvent the Wheel
It is possible to create your entire coding library from scratch, but it likely isn’t the best option. You can simply use a tested and certified C# coding library. There are several libraries out there that will be useful to you as a beginning and will help you to prevent errors.

Establish Code Conventions
The minute you begin to work on C# projects , you will inevitably have a code style convention. This is because you will have already decided what format indentation to use, your preferred syntax, and the use of “var.” It is good to establish a code style because it ensures consistency and readability.

The best option is to automate your decisions and use a compiler or formatting tool to ensure that the decisions are enforced.

Use Prefix Interfaces with Letter ‘i’
The main reason that developers use the prefix “i” is that this piece of code is commonly used by C# developers, so if you use it, other developers will be able to read your code. Another reason to prefix interfaces with “i” is that the solution explorer in Visual Studio won’t have to distinguish between classes and interfaces.

So, the letter “i” is the best way to determine whether a file represents a class or an interface.

Use Nullable Data Types
C# allows you to store as null integer values, double, or boolean variables in certain situations. All you have to do is use the modifier “?” immediately after the type. This is a good option because the standard declaration doesn’t typically allow the use of null stored as a value. This will mostly come up when used with boolean properties.

Runtime Constants are the Preferred Constants
Runtime constants, denoted by the keyword “readonly,” are analyzed while the program is running. Compile-time constants are static values that are evaluated during compilation and are represented with the keyword “const.” Their value will not change each time the source code is executed. Because compile-time constants cannot be changed, they must be initialized when they are declared.
On the other hand, runtime constants can be altered at any point during the initialization process and can be set in the constructor. As a result, it is best to use runtime constants when writing reliable code and compile-time constants if you’re in a hurry.

Use Conditional Attributes
It’s a good idea to use the #if or #endif block to perform specific actions for the debug version of your code. However, there are some disadvantages, and you could end up with a bug in your code. This is where conditional attributes come into play. Conditional attributes can help you avoid the pitfalls of #if and #endif statements. You can use these attributes by putting your code in a method and setting the conditional attribute to the DEBUG string. The method will be called when your application is in debug mode but not in all cases.

Only Catch Exceptions that You can Handle
Using the generic exception class to catch any exception will result in a lousy application with poor system performance. You should only catch what you expect and order it in accordance. If you want, you can add the generic exception at the end to catch any other unknown exceptions. This will make it easy for you to handle any potential problem.


----------------------------------Improved C# Best Coding Practises-------------------------------------
1. Make sure that there shouldn’t be any project warnings, treat warning as errors

2. It will be much better if Code Analysis is performed on a project (with all Microsoft Rules enabled) and then remove the warnings.

3. Use asynchronous programming using C# async await where application, as it tremendously improves the performance

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/

4. Use C# new language features, for example use nameof operator to get the property/method names instead of hard coding it

if (IsNullOrWhiteSpace(lastName))

throw new ArgumentException(message: “Cannot be blank”, paramName: nameof(lastName));

5. All unused usings need to be removed. Code cleanup for unnecessary code is always a good practice.

6. ‘null’ check needs to be performed wherever applicable to avoid the Null Reference Exception at runtime, use C# 6.0 new feature “Null-conditional operators” for this, one example as given below

var first = person?.FirstName;

For more explanation on this, please refer below link

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6

7. Follow best practices while writing code by following SOLID principle and software design patterns

https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/

https://www.dofactory.com/net/design-patterns

8. Write loosely coupled components, follow dependency injection concept, extremely important, helps while doing unit testing as well

https://www.dotnetcurry.com/software-gardening/1284/dependency-injection-solid-principles

9. Code Reusability: Extract a method if the same piece of code is being used more than once or you expect it to be used in future. Make some generic methods for repetitive task and put them in a related class so that other developers start using them once you intimate them. Develop user controls for common functionality so that they can be reused across the project.

Refer:

o http://msdn.microsoft.com/en-us/library/office/aa140806(v=office.10).aspx

o http://blogs.msdn.com/b/frice/archive/2004/06/11/153709.aspx

10. Code Consistency: Let’s say that an Int32 type is coded as int and String type is coded as string, then they should be coded in that same fashion across the application. But not like sometimes int and sometimes as Int32.

11. Code Readability: Should be maintained so that other developers understand your code easily.

Refer: http://msdn.microsoft.com/en-IN/library/aa291591(v=vs.100).aspx

12. Disposing of Unmanaged Resources like File I/O, Network resources, etc. They have to be disposed of once their usage is completed. Use usings block for unmanaged code, if you want to automatically handle the disposing of objects once they are out of scope.

Refer: http://msdn.microsoft.com/en-us/library/498928w2.aspx

Use new feature of deallocating unmanaged resources, details in link below

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#using-declarations

13. Proper implementation of Exception Handling (try/catch and finally blocks) and logging of exceptions.

Refer: http://msdn.microsoft.com/en-us/library/vstudio/ms229005(v=vs.100).aspx

14. Naming conventions to be followed always. Generally for variables/parameters, follow Camel casing and for method names and class names, follow Pascal casing.

Refer: http://msdn.microsoft.com/en-us/library/ms229043.aspx.

15. Making sure that methods have less number of lines of code. Not more than 20 to 30 lines

16. Timely check-in/check-out of files/pages at source control (like TFS).

Refer: http://www.codeproject.com/Tips/593014/Steps-Check-in-Check-Out-Mechanism-for-TFS-To-avoi

17. Peer code reviews. Swap your code files/pages with your colleagues to perform internal code reviews.

18. Unit Testing. Write developer test cases and perform unit testing to make sure that basic level of testing is done before it goes to QA testing.

Refer: https://msdn.microsoft.com/en-us/library/hh694602.aspx

19. Avoid nested for/foreach loops and nested if conditions as much as possible.

20. Use anonymous types if code is going to be used only once.

Refer: http://msdn.microsoft.com/en-us/library/vstudio/bb397696.aspx

21. Try using LINQ queries and Lambda expressions to improve Readability.

Refer: http://msdn.microsoft.com/en-us/library/bb308959.aspx

22. Use PLINQ wherever applicable, as it makes parallel operation within LINQ query and improves the performance

https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/introduction-to-plinq

23. Proper usage of var, object, and dynamic keywords. They have some similarities due to which most of the developers are confused or don’t know much about them and hence they use them interchangeably, which shouldn't be the case.

Refer: http://blogs.msdn.com/b/csharpfaq/archive/2010/01/25/what-is-the-difference-between-dynamic-and-object-keywords.aspx

24. Use access specifiers (private, public, protected, internal, protected internal) as per the scope need of a method, a class, or a variable. Let’s say if a class is meant to be used only within the assembly, then it is enough to mark the class as internal only.

Refer: http://msdn.microsoft.com/en-us/library/kktasw36.aspx

25. Use interfaces wherever needed to maintain decoupling. Some design patterns came into existence due to the usage of interfaces.

Refer: http://msdn.microsoft.com/en-IN/library/3b5b8ezk(v=vs.100).aspx

26. Mark a class as sealed or static or abstract as per its usage and your need.

Refer: http://msdn.microsoft.com/en-us/library/ms173150(v=vs.100).aspx

27. Use a Stringbuilder instead of string if multiple concatenations are required, to save heap memory.

28. Check whether any unreachable code exists and modify the code if it exists.

29. Write comments on top of all methods to describe their usage and expected input types and return type information.

30. Use fiddler/Postman tool to check the HTTP/network traffic and bandwidth information to trace the performance of web application and services.

31. Use constants and readonly wherever applicable.

Refer:

o http://msdn.microsoft.com/en-us/library/acdd6hb7(v=vs.100).aspx

o http://msdn.microsoft.com/en-us/library/e6w8fe1b(v=vs.100).aspx

32. Avoid type casting and type conversions as much as possible; because it is a performance penalty.

Refer: http://msdn.microsoft.com/en-us/library/ms173105.aspx

33. Override ToString (from Object class) method for the types which you want to provide with custom information.

Refer: http://msdn.microsoft.com/en-us/library/ms173154(v=vs.100).aspx

34. Avoid straightaway copy/pasting of code from other sources. It is always recommended to hand write the code even though if you are referring to the code from some sources. By this, you will get good practice of writing the code yourself and also you will understand the proper usage of that code; finally you will never forget it.

35. Always make it a practice to read books/articles, upgrade and follow the Best Practices and Guidelines by industry experts like Microsoft experts and well-known authors like Martin Fowler, Kent Beck, Jeffrey Ritcher, Ward Cunningham, Scott Hanselman, Scott Guthrie, Donald E Knuth.

36. Verify whether your code have any memory leakages. If yes, make sure that they have been fixed.

Refer: http://blogs.msdn.com/b/davidklinems/archive/2005/11/16/493580.aspx

37. Try attending technical seminars by experts to be in touch with the latest software trends and technologies and best practices.

38. Understand thoroughly the OOPs concepts and try implementing it in your code.

39. Get to know about your project design and architecture to better understand the flow of your application as a whole.

40. Take necessary steps to block and avoid any cross scripting attacks, SQL injection, and other security holes, follow all OWASP top 10 security rules

https://owasp.org/www-project-top-ten/

41. Always encrypt (by using good encryption algorithms) secret/sensitive information like passwords while saving to database and connection strings stored in web.config file(s) to avoid manipulation by unauthorized users.

42. Avoid using default keyword for the known types (primitive types) like int, decimal, bool, etc. Most of the times, it should be used in case of Generic types (T) as we may not be sure whether the type is a value type or reference type.

Refer: http://msdn.microsoft.com/en-us/library/xwth0h0d(v=vs.100).aspx

43. Usage of ‘out' and 'ref' keywords be avoided as recommended by Microsoft (in the Code analysis Rules and guidelines). These keywords are used to pass parameters by reference. Note that 'ref' parameter should be initialized in the calling method before passing to the called method but for 'out' parameter this is not mandatory.

44. C# language has tremendously improved over a period of time, always use new features while writing programs, below are the latest C# msdn links

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7

https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8