# Filter by Predicate. Interfaces

Intermediate level task for practicing interfaces, strategy pattern.

Estimated time to complete the task - 1.5h.

The task requires .NET 8 SDK installed.

## Task description

- Develop the [ArrayExtensions](ArrayExtensions) class with following methods:

    - the `FilterByDigit` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that contain the given digit;
    - the `FilterByPalindromic` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that are palindromes.    
    _When implementing these methods, follow the suggested skeletons._

- Analyze the resulting methods:
    - what part of their code is the same?
    - which part depends on a specific _predicate_*?      
    _*A predicate  is a statement made about a subject. The subject of the statement is that about which the statement is made. A predicate in programming is an expression that uses one or more values with a boolean result._

    _Discuss this question and your answer with your trainer, if you work in a regular group._

- In this task predicate is defined as a `IsMatch` method of the [IPredicate](FilterByPredicate/IPredicate.cs) interface. The implementation details of the predicate logic are left to the derived classes.

- Put the common part of the code as a skeleton of operations in the `Select` extesion method of the [ArrayExtensions](FilterByPredicate) static class. The method must contain the `IPredicate` interface as a parameter.

- Develop derived classes for described above predicates. Place the solutions in two separate projects:

    - [Filter by Digit](FilerByDigit);
    - [Filter by Palindromic](FilterByPalindromic).
