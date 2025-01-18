# Getting an Array Element Index

Beginner level task for practicing loops and arrays.

In the task you have to implement six "GetIndexOf" methods that should return the zero-based index (position) of the first occurrence of the specified character ("value" parameter) in the string that is passed as a "str" parameter.

Estimated time to complete the task - 1h.

The task requires .NET 8 SDK installed.

## Task Description

The implementation details are described in TODO comments in code files. There are six "GetLastIndexOf" methods that you can use as examples. The methods are implemented using recursion. Debug and analyze the methods to understand their algorithms BEFORE starting to implement required methods.

Use the _for_, _while_ and _do..while_ statements to repeatedly execute a block of C# statements. Don't use static or instance methods of the [Array class](https://docs.microsoft.com/en-us/dotnet/api/system.array) (IndexOf, LastIndexOf, Find, ForEach, etc.) or [LINQ functionality](https://docs.microsoft.com/en-us/dotnet/api/system.linq).

1. Analyze the implementation of the [GetLastIndexOf(uint[], uint)](GettingArrayElementIndex/ForMethods.cs#L17) method in the _ForMethods.cs_ file. Implement the [GetIndexOf(uint[], uint)](GettingArrayElementIndex/ForMethods.cs#L5) static method. See TODO #1.
1. Analyze the implementation of the [GetLastIndexOf(uint[], uint, int, int)](GettingArrayElementIndex/ForMethods.cs#L35) method in the _ForMethods.cs_ file. Implement the [GetIndexOf(uint[], uint, int, int)](GettingArrayElementIndex/ForMethods.cs#L11) static method. See TODO #2.
1. Analyze the implementation of the [GetLastIndexOf(ushort[], ushort)](GettingArrayElementIndex/WhileMethods.cs#L17) method in the _WhileMethods.cs_ file. Implement the [GetIndexOf(ushort[], ushort)](GettingArrayElementIndex/WhileMethods.cs#L5) static method. See TODO #3.
1. Analyze the implementation of the [GetLastIndexOf(ushort[], ushort, int, int)](GettingArrayElementIndex/WhileMethods.cs#L38) method in the _WhileMethods.cs_ file. Implement the [GetIndexOf(ushort[], ushort, int, int)](GettingArrayElementIndex/WhileMethods.cs#L11) static method. See TODO #4.
1. Analyze the implementation of the [GetLastIndexOf(ulong[], ulong)](GettingArrayElementIndex/DoWhileMethods.cs#L17) method in the _DoWhileMethods.cs_ file. Implement the [GetIndexOf(ulong[], ulong)](GettingArrayElementIndex/DoWhileMethods.cs#L5) static method. See TODO #5.
1. Analyze the implementation of the [GetLastIndexof(ulong[], ulong, int, int)](GettingArrayElementIndex/DoWhileMethods.cs#L42) method in the _DoWhileMethods.cs_ file. Implement the [GetIndexOf(ulong[], ulong, int, int)](GettingArrayElementIndex/DoWhileMethods.cs#L11) static method. See TODO #6.


## See also

* C# Reference
  * [for statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)
  * [while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)
  * [do..while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do)
  * [Increment operator ++](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#increment-operator-)
  * [Decrement operator --](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#decrement-operator---)
  * [Creating and Throwing Exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions)
* .NET API
  * [Array.Length](https://docs.microsoft.com/en-us/dotnet/api/system.array.length)
  * [Array.IList.Item](https://docs.microsoft.com/en-us/dotnet/api/system.array.system-collections-ilist-item)
