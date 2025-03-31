# Type Conversions

Beginner level task for practicing implicit/explicit reference conversions and boxing/unboxing conversions.

Estimated time to complete the task - 0.5h.

The task requires .NET 8 SDK installed.


## Task Description

The purpose of this task is to help you better understand the concept following type conversions:    
- implicit and explicit reference conversions;   
- boxing and unboxing conversions.

### Boxing conversions

- Open the [Point.cs](TypeConversions/TypesForConversions/Point.cs) file and inspect the code of the [Point](TypeConversions/TypesForConversions/Point.cs#L3) structure.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [BoxingConversions.cs](TypeConversions/BoxingConversions.cs) file and implement all methods of the [BoxingConversions](TypeConversions/BoxingConversions.cs#L6) class using the information of the XML-comments.

### Unboxing conversions 

- Open the [Point.cs](TypeConversions/TypesForConversions/Point.cs) file and inspect the code of the [Point](TypeConversions/TypesForConversions/Point.cs#L3) structure.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [UnboxingConversions.cs](TypeConversions/UnboxingConversions.cs) file and implement all methods of the [UnboxingConversions](TypeConversions/UnboxingConversions.cs#L6) class by using 
    - [cast expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression)
    - [as operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator)
    - [pattern matching](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#is-operator)   
    For more detailed information use the XML-comments.

### Implicit Reference Conversions

- Open the [Shape.cs](TypeConversions/TypesForConversions/Shape.cs) file and inspect the code of the [Shape](TypeConversions/TypesForConversions/Point.cs#L3) class.
- Open the [Circle.cs](TypeConversions/TypesForConversions/Circle.cs) file and inspect the code of the [Circle](TypeConversions/TypesForConversions/Circle.cs#L5) class.
- Open the [Square.cs](TypeConversions/TypesForConversions/Square.cs) file and inspect the code of the [Square](TypeConversions/TypesForConversions/Square.cs#L5) enumerator.
- Open the [IColorable.cs](TypeConversions/TypesForConversions/IColorable.cs) file and inspect the code of the [IColorable](TypeConversions/TypesForConversions/IColorable.cs#L3) interface.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [ImplicitReferenceConversions.cs](TypeConversions/ImplicitReferenceConversions.cs) file and implement all methods of the [ImplicitReferenceConversions](TypeConversions/ImplicitReferenceConversions.cs#L6) class using the information of the XML-comments.

### Explicit Reference Conversions

- Open the [Shape.cs](TypeConversions/TypesForConversions/Shape.cs) file and inspect the code of the [Shape](TypeConversions/TypesForConversions/Point.cs#L3) class.
- Open the [Circle.cs](TypeConversions/TypesForConversions/Circle.cs) file and inspect the code of the [Circle](TypeConversions/TypesForConversions/Circle.cs#L5) class.
- Open the [Square.cs](TypeConversions/TypesForConversions/Square.cs) file and inspect the code of the [Square](TypeConversions/TypesForConversions/Square.cs#L5) enumerator.
- Open the [IColorable.cs](TypeConversions/TypesForConversions/IColorable.cs) file and inspect the code of the [IColorable](TypeConversions/TypesForConversions/IColorable.cs#L3) interface.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [ExplicitReferenceConversions.cs](TypeConversions/ExplicitReferenceConversions.cs) file and implement all methods of the [ExplicitReferenceConversions](TypeConversions/ExplicitReferenceConversions.cs#L6) class by using 
    - [cast expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression)
    - [as operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator)
    - [pattern matching](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#is-operator)   
    For more detailed information use the XML-comments.

## See also

* C# Programming Guide
  * [Casting and type conversions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
  * [Boxing and Unboxing](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
  * [How to safely cast by using pattern matching and the is and as operators](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/safely-cast-using-pattern-matching-is-and-as-operators)  
  * [Type-testing operators and cast expressions - is, as, typeof and casts](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator)
