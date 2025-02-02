# The Time Struct 

Intermediate level task for practicing structures.

Estimated time to complete the task - 1h.

The task requires .NET 6 SDK installed.

## Task Details
Design a *immutable* struct `Time` (add code in [Time.cs](TimeStruct/Time.cs#L1) file in `TimeStruct Project`) that represents the times in `24`-hours format without date according to the following requirements.    
- The `Time` struct should have two constructors.
    - First `Time` constructor has an integer parameter `minutes`. 
    - Second `Time` constructor has an integer parameters `hours` (first parameter) and `minutes` (second parameter). 
    - The first constructor uses the `this` keyword to call the second constructor.
    - Value of `hours` and `minutes` parameters can be any (including negative, time `00:00` is considered as a origin) and are converted into the standard range for hours `(0..23)` and minutes `(0..59)`.
- The `Time` struct should have following properties.
    - `Hours` is a *read-only* `System.Int32` property that indicates hours in `24`-hours format and whose value is supplied by calling the `Time` constructor.
    - `Minutes` is a *read-only* `System.Int32` property that indicates minutes in `60`-minuts format and whose value is supplied by calling the `Time` constructor.
- The `Time` struct should have following methods:
    - A `ToString` method to return the information about time. For example, for the object with the values `Hours = 8, Minutes = 45`, method returns following string `"08:45"` (use `new` modifier).
- The `Time` struct should have [Deconstruct](https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct#deconstructing-user-defined-types) method.
-  For a detailed description of the `Time` struct, see [test cases](TimeStruct.Tests/TimeTests.cs). 
