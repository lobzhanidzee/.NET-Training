# Arrays

Beginner level task for practicing arrays.

Estimated time to complete the task - 1h.

The task requires .NET 8 SDK installed.

## Task Description

### Creating Arrays

In the [CreateEmptyArrayOfIntegers](Arrays/CreatingArray.cs#L8) method return an empty array.

```cs
public static int[] CreateEmptyArrayOfIntegers()
{
    return new int[0];
}
```

In the [CreateEmptyArrayOfBooleans](Arrays/CreatingArray.cs#L15) method initialize an array variable with empty initialization list and return an empty array.

```cs
public static bool[] CreateEmptyArrayOfBooleans()
{
    bool[] array = { };
    return array;
}
```

In the [CreateEmptyArrayOfStrings](Arrays/CreatingArray.cs#L23) method return an empty array using the syntax with an empty initialization list.

```cs
public static string[] CreateEmptyArrayOfStrings()
{
    return new string[] { };
}
```

Implement the _CreateEmptyArrayOfCharacters_ method in the same way.

In the [CreateEmptyArrayOfDoubles](Arrays/CreatingArray.cs#L38) method return an empty array by calling the [Array.Empty&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.array.empty) method.

```cs
public static double[] CreateEmptyArrayOfDoubles()
{
    return Array.Empty<double>();
}
```

Using the _Array.Empty&lt;T&gt;_ method to create an empty array is more preferable way, because empty arrays created by the _Array.Empty&lt;T&gt;_ method are cached in a .NET application and reused.

Implement all static methods in [CreatingArray.cs](Arrays/CreatingArray.cs) file. See the method documentation and TODO comments.


### Accessing Array Elements

In the [GetFirstArrayElement](Arrays/UsingIndexerForAccessingArrayElement.cs#L5) method return the first array element.

```cs
public static int GetFirstArrayElement(int[] array)
{
    return array[0];
}
```

In the [GetLastElement](Arrays/UsingIndexerForAccessingArrayElement.cs#L23) method return the last array element.

```cs
public static int GetLastElement(int[] array)
{
    return array[array.Length - 1];
}
```

The [Array.Length](https://docs.microsoft.com/en-us/dotnet/api/system.array.length) property returns an array length.

In the [GetLastElement](Arrays/UsingIndexerForAccessingArrayElement.cs#L145) method return the last array element using the [index from end operator ^](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes).

```cs
public static double GetLastElement(double[] array)
{
    return array[^1];
}
```

Implement all static methods in [UsingIndexerForAccessingArrayElement.cs](Arrays/UsingIndexerForAccessingArrayElement.cs) file. See the method documentation and TODO comments.


### Ranges

[Ranges](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges) is C# 8 feature that allows to get a subrange of an array.

In the [GetArrayWithAllElements](Arrays/UsingRanges.cs#L7) method return the subrange with all array elements using [range operator ..](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges#systemrange).

```cs
public static int[] GetArrayWithAllElements(int[] array)
{
    return array[0..^0];
}
```

The range operator has two operands. Either operand can be omitted:

```cs
public static int[] GetArrayWithAllElements(int[] array)
{
    return array[..];
}
```

The both methods above are equivalent.

In the [GetArrayWithoutFirstElement](Arrays/UsingRanges.cs#L14) method return an array subrange without the first element.

```cs
public static int[] GetArrayWithoutFirstElement(int[] array)
{
    return array[1..];
}
```

In the [GetArrayWithoutLastElement](Arrays/UsingRanges.cs#L32) method return an array subrange without the last element.

```cs
public static int[] GetArrayWithoutLastElement(int[] array)
{
    return array[..^1];
}
```

Implement all static methods in [UsingRanges.cs](Arrays/UsingRanges.cs) file. See the method documentation and TODO comments.


## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintaining consistency of the project source code and avoiding silly mistakes. [Review the Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google the error or warning code to get more information about the issue.


## Task Checklist

1. Rebuild the solution.
1. Fix all compiler warnings and errors.
1. Run all unit tests, make sure all unit tests completed successfully.
1. Review all changes, make sure the only code files (.cs) in Arrays project have changes. No changes in project files (.csproj) or in Arrays.Tests project.
1. Stage your changes, and create a commit.
1. Push your changes to remote repository.


## See also

* Tutorials
  * [Indices and ranges](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes)
* C# Programming Guide
  * [Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
* .NET API
  * [Array Class](https://docs.microsoft.com/en-us/dotnet/api/system.array)
