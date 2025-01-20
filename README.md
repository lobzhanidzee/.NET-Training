# Looking for an Array Element

Intermediate level task for practicing loops, branches and arrays.

The task is to implement six methods using "for", "while" and "do" statements.

Estimated time to complete the task - 2h.

The task requires .NET 8 SDK installed.

## Task Description

You are allowed to use loop statements (for, while and do), [Array.Length](https://docs.microsoft.com/en-us/dotnet/api/system.array.length) and [Array.IList.Item[Int32]](https://docs.microsoft.com/en-us/dotnet/api/system.array.system-collections-ilist-item) properties only. You are not allowed to use other static or instance methods of the [Array class](https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1) or any extension method from [System.Linq namespace](https://docs.microsoft.com/en-us/dotnet/api/system.linq). You can create your private [static methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members) or [local functions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions).

1. Implement "GetIntegersCount(int[], int[])" method in the [IntegersCounter.cs](LookingForArrayElements/IntegersCounter.cs) file. The method should count all elements of "arrayToSearch" array that appears in "elementsToSearchFor" array.

Here's an example for ["GetIntegersCount_ParametersAreValid_ReturnsResult"](LookingForArrayElements.Tests/IntegersCounterTests.cs#L55) unit test.

arrayToSearch is an array with { 1, 2, 3, 4, 5, 6, 7, 8, 9 } elements, and elementsToSearchFor is an array with { 2, 5, 8 } elements.

| Position in arrayToSearch  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |
|----------------------------|---|---|---|---|---|---|---|---|---|
| arrayToSearch values       | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
| elementsToSearchFor values |   | 2 |   |   | 5 |   |   | 8 |   |
| Sum = 3                    | 0 | 1 | 0 | 0 | 1 | 0 | 0 | 1 | 0 |


2. Implement "GetIntegersCount(int[], int[], int, int)" method in the [IntegersCounter.cs](LookingForArrayElements/IntegersCounter.cs) file. The method should work like the previous one, but it has additional options (startIndex and count) that can be used for getting a subset of arrayToSearch.

Here's an example for ["GetIntegersCount_ParametersAreValid_ReturnsResult"](LookingForArrayElements.Tests/IntegersCounterTests.cs#L136) unit test.

arrayToSearch is an array with { 1, 2, 3, 4, 5, 6, 7, 8, 9 } elements, and elementsToSearchFor is an array with { 2, 5, 8 } elements. startIndex is 2, and count is 5.

| Position in arrayToSearch  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |
|----------------------------|---|---|---|---|---|---|---|---|---|
| arrayToSearch values       | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
| elementsToSearchFor values |   | 2 |   |   | 5 |   |   | 8 |   |
| startIndex & count         |   |   | 1 | 2 | 3 | 4 | 5 |   |   |
| Sum = 1                    | 0 | 0 | 0 | 0 | 1 | 0 | 0 | 0 | 0 |


3. Implement "GetFloatsCount(float[], float[], float[])" method in the [FloatCounter.cs](LookingForArrayElements/FloatCounter.cs) file. The method should count all elements of "arrayToSearch" array that appears in ranges defined by values in "rangeStart" and "rangeEnd" arrays.

Here's an example for ["GetFloatsCount_ParametersAreValid_ReturnsResult"](LookingForArrayElements.Tests/FloatCounterTests.cs#L92) unit test.

arrayToSearch is an array with { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f } elements, rangeStart array has { 0.1f, 0.8f } elements, rangeEnd array has { 0.2f, 0.9f } elements. That means the first range is 0.1f-0.2f, and the second tange is 0.8f-0.9f.

| Position in arrayToSearch  |   0  |   1  |    2 |   3  |   4  |   5  |   6  |   7  |   8  |
|----------------------------|------|------|------|------|------|------|------|------|------|
| arrayToSearch values       | 0.1f | 0.2f | 0.3f | 0.4f | 0.5f | 0.6f | 0.7f | 0.8f | 0.9f |
| 0.1f-0.2f range            | 0.1f | 0.2f |      |      |      |      |      |      |      |
| 0.8f-0.9f range            |      |      |      |      |      |      |      | 0.8f | 0.9f |
| Sum = 4                    |   1  |   1  |   0  |   0  |   0  |   0  |   0  |   1  |   1  |


4. Implement "GetFloatsCount(float[], float[], float[], int, int)" method in the [FloatCounter.cs](LookingForArrayElements/FloatCounter.cs) file. See the method documentation and TODO.
5. Implement "GetDecimalsCount(decimal[], decimal[][])" method in the [DecimalCounter.cs](LookingForArrayElements/DecimalCounter.cs) file. See the method documentation and TODO.
6. Implement "GetDecimalsCount(decimal[], decimal[][], int, int)" method in the [DecimalCounter.cs](LookingForArrayElements/DecimalCounter.cs) file. See the method documentation and TODO.


## See also

* Tour of C#
  * [Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/arrays)
* C# Programming Guide
  * [Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
* C# Reference
  * [for statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)
  * [while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)
  * [do..while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do)
* .NET API
  * [Array.Length Property](https://docs.microsoft.com/en-us/dotnet/api/system.array.length)
  * [Array.IList.Item[Int32] Property](https://docs.microsoft.com/en-us/dotnet/api/system.array.system-collections-ilist-item)
