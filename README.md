# Generic Sequence Generators

A intermediate level task for practicing object-oriented programming.

Estimated time to complete the task: 2 hour.

The task requires .NET 8 SDK installed.

## Task Description

Implement a class library of generators of sequences of elements of various types.

### 1. Generic Sequence Generator Interface

- Create a generic interface `ISequenceGenerator<T>`.
- Define the following properties:
    - `Previous` of type `T`, representing the previous element in the sequence.
    - `Current` of type `T`, representing the current element in the sequence.
    - `Next` of type `T`, representing the next element in the sequence.

### 2. Generic Sequence Generator Class

- Create an abstract class `SequenceGenerator<T>` that implements the `ISequenceGenerator<T>` interface.
- Provide a constructor that initializes two first values of the sequence.
- Implement the properties `Previous` and `Current` with appropriate accessors.
- Define a public property `Count`, representing the number of elements generated in the sequence. The property should have a public getter and a private setter.
- Define an abstract method called `GetNext()` that returns an element of type `T` of the specific sequence.

### 3. Fibonacci Sequence Generator Class

- Create a class called `FibonacciSequenceGenerator` that inherits from `SequenceGenerator<int>`.
- Provide a constructor that initializes two first values of the sequence.
- Implement the `GetNext()` method to generate the next Fibonacci number based on the previous and current values. The Fibonacci sequence starts with two initial values (e.g., 0 and 1), and each subsequent number is the sum of the previous two.

### 4. Integer Sequence Generator Class
- Create a class called `IntegerSequenceGenerator` that inherits from `SequenceGenerator<int>`.
- Provide a constructor that initializes two first values of the sequence.
- Implement the `GetNext()` method to generate the elements of the sequence based the following rule:

  $`x_1 = 1, x_2 = 2, x_{n + 1} = 6 x_n - 8 x_{n - 1}, n = 2, 3, ... ,`$.

Data for tests: { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 }, ,` n = 10`

### 5. Double Sequence Generator Class
- Create a class called `DoubleSequenceGenerator` that inherits from `SequenceGenerator<int>`.
- Provide a constructor that initializes two first values of the sequence.
- Implement the `GetNext()` method to generate the elements of the sequence based the following rule:

  $`x_1 = 1, x_2 = 2, x_{n + 1} = x_n +  x_{n - 1} / x_{n}, n = 2, 3, ...,`$.

Data for tests: {1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137},` n = 10`

### 6. Char Sequence Generator Class
- Create a class called `CharSequenceGenerator` that inherits from `SequenceGenerator<int>`.
- Provide a constructor that initializes two first values of the sequence.
- Implement the `GetNext()` method to generate the elements of the sequence based the following rule:

  $`x_1 = a, x_2 = b, x_{n + 1} = (x_n +  x_{n - 1}) % 26 + 'A', n = 2, 3, ...,`$ where `a, b` - `char`.

Data for tests: {'A', 'B', 'B', 'C', 'D', 'F', 'I', 'N', 'V', 'I'},` n = 10`

### 7. Generic Sequence Generator Class With Delegate

- Use a delegate type to implement a generalized generator of the `n`-first members of a sequence specified by a recurrent formula for elements of type `T` according to the rule

  $`x_1 = a, x_2 = b, x_{n+1}=f(x_n, x_{n - 1}), n = 2, 3, ...`$


**Note**
_The solution will not compile until all required types with required members are implemented. For a smoother development experience, we recommend initially declaring all necessary types and creating "stub methods" as follows:_

```csharp
public returnType MethodName(parameters list)
{
    throw new NotImplementedException();
}
```

_This approach allows you to build and run your project incrementally while implementing each method._