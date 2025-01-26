# Getting The Character Index

Beginner level task for practicing loops (for, while, do..while).

In the task you have to implement six "GetIndexOfChar" methods that should return the zero-based index (position) of the first occurence of the specified character ("value" parameter) in the string that is passed as a "str" parameter.

Estimated time to complete the task - 1h.

The task requires .NET 8 SDK installed.

## Task Description

The implementation details are described in TODO comments in code files. There are six "GetLastIndexOfChar" methods that you can use as examples. Analyze these methods and run unit tests for them before you start to implement methods you have to implement.

It's allowed to use [String.Length](https://docs.microsoft.com/en-us/dotnet/api/system.string.length) and [String.Chars](https://docs.microsoft.com/en-us/dotnet/api/system.string.chars) properties only for solving the task. You are not allowed to use other static or instance methods of the [String class](https://docs.microsoft.com/en-us/dotnet/api/system.string) or any extension method from [System.Linq namespace](https://docs.microsoft.com/en-us/dotnet/api/system.linq).

1. Analyze the implementation of the "GetLastIndexOfChar(string, char)" method in the [ForMethods.cs](GettingCharIndex/ForMethods.cs) file. Implement the "GetIndexOfChar(string, char)" static method. See TODO #1.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char, int, int)" method in the [ForMethods.cs](GettingCharIndex/ForMethods.cs) file. Implement the "GetIndexOfChar(string, char, int, int)" static method. See TODO #2.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char)" method in the [WhileMethods.cs](GettingCharIndex/WhileMethods.cs) file. Implement the "GetIndexOfChar(string, char)" static method. See TODO #3.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char, int, int)" method in the [WhileMethods.cs](GettingCharIndex/WhileMethods.cs) file. Implement the "GetIndexOfChar(string, char, int, int)" static method. See TODO #4.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char)" method in the [DoWhileMethods.cs](GettingCharIndex/DoWhileMethods.cs) file. Implement the "GetIndexOfChar(string, char)" static method. See TODO #5.
1. Analyze the implementation of the "GetLastIndexofChar(string, char, int, int)" method in the [DoWhileMethods.cs](GettingCharIndex/DoWhileMethods.cs) file. Implement the "GetIndexOfChar(string, char, int, int) static method. See TODO #6.


## See also

* C# Reference
  * [for statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)
  * [while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)
  * [do..while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do)
  * [foreach..in statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in)
  * [Increment operator ++](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#increment-operator-)
  * [Decrement operator --](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#decrement-operator---)
  * [Creating and Throwing Exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions)
* .NET API
  * [String.Length Property](https://docs.microsoft.com/en-us/dotnet/api/system.string.length)
  * [String.Chars Property](https://docs.microsoft.com/en-us/dotnet/api/system.string.chars)
